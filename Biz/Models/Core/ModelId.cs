using System;

namespace MicroBlessingsApi.Biz.Models.Core
{
   /// <summary>
   /// The <c>IModelId</c>'s purpose is to uniquely identify a <see cref="IModelObject{T}"/> in the system.
   /// </summary>
   [Serializable]
   public class ModelId<T> : IEquatable<ModelId<T>> where T : class, IModelObject<T>
   {
      /// <summary>
      /// Copy constructor.
      /// </summary>
      /// <param name="modelId">The model identifier to copy.</param>
      public ModelId(ModelId<T> modelId)
         : this(modelId.ModelKey, modelId.VersionNumber)
      {
      }

      /// <summary>
      /// Constructs a new model identifier with the <paramref name="modelId"/>'s internal key
      /// and the given <paramref name="versionNumber"/>.
      /// </summary>
      /// <param name="modelId">The model identifier to copy.</param>
      /// <param name="versionNumber">The version number associated with this new model identifier.</param>
      public ModelId(ModelId<T> modelId, int versionNumber)
         : this(modelId.ModelKey, versionNumber)
      {
      }

      /// <summary>
      /// Standard parameterized constructor that uses the given <paramref name="modelKey"/> and
      /// <paramref name="versionNumber"/>.
      /// </summary>
      /// <param name="modelKey">The unique key value for the model identifier.</param>
      /// <param name="versionNumber">The version number associated with the model identifier.</param>
      public ModelId(Guid modelKey, int versionNumber = VersionInfo.NonVersioned)
      {
         ModelKey = modelKey;
         VersionNumber = versionNumber;
      }

      /// <summary>
      /// Gets the unique key for the model instance.
      /// </summary>
      public Guid ModelKey { get; private set; }

      /// <summary>
      /// Gets the specific version number of the model instance.
      /// </summary>
      /// <seealso cref="VersionInfo.DefaultVersion"/>
      /// <seealso cref="VersionInfo.NonVersioned"/>
      public int VersionNumber { get; private set; }

      /// <summary>
      /// Comparison implementation that compares keys.  Version numbers
      /// are not factored into equality comparisons.
      /// </summary>
      /// <param name="obj">The model identifier to compare to.</param>
      /// <returns><c>true</c> if the <see cref="ModelId{T}"/>s are considered equal; 
      /// otherwise <c>false</c> is returned.</returns>
      public bool Equals(ModelId<T> obj)
      {
         // If parameter is null return false.
         if (ReferenceEquals(null, obj))
         {
            return false;
         }

         // If these are the same references then return true.
         if (ReferenceEquals(this, obj))
         {
            return true;
         }

         // Match on the individual fields.
         return obj.ModelKey.Equals(ModelKey);
      }

      public override bool Equals(object obj)
      {
         // If parameter is null return false.
         if (ReferenceEquals(null, obj))
         {
            return false;
         }

         // If these are the same references then return true.
         if (ReferenceEquals(this, obj))
         {
            return true;
         }

         // If these objects refer to different types then return false
         if (obj.GetType() != typeof(ModelId<T>))
         {
            return false;
         }

         return Equals((ModelId<T>)obj);
      }

      /// <summary>
      /// Equality operator implementation.
      /// </summary>
      public static bool operator ==(ModelId<T> a, ModelId<T> b)
      {
         // If both are null, or both are same instance, return true.
         if (ReferenceEquals(a, b))
         {
            return true;
         }

         // If either are null, return false.
         if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

         // Return true if the fields match
         return a.ModelKey.Equals(b.ModelKey);
      }

      /// <summary>
      /// Inequality operator implementation.
      /// </summary>
      public static bool operator !=(ModelId<T> a, ModelId<T> b)
      {
         return !(a == b);
      }

      /// <summary>
      /// A string representation of this instance.  The format of the returned string is not fixed and
      /// logic should not be based off of it.
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return string.Format("{0}^{1}^{2}", typeof(T).FullName, ModelKey, VersionNumber);
      }

      /// <summary>
      /// <see cref="object.GetHashCode"/>
      /// </summary>
      public override int GetHashCode()
      {
         return ModelKey.GetHashCode();
      }

      /// <summary>
      /// Parses the <see cref="ModelKey"/> portion of a <see cref="ModelId{T}"/> into
      /// an instance of <see cref="ModelId{T}"/>.
      /// </summary>
      /// <param name="modelKeyString">The model key string to parse.</param>
      /// <returns>The parsed model id instance.</returns>
      /// <exception cref="ArgumentException">Thrown if <paramref name="modelKeyString"/> is in an invalid
      /// format.</exception>
      public static ModelId<T> Parse(string modelKeyString)
      {
         try
         {
            Guid modelKey = new Guid(modelKeyString);
            return new ModelId<T>(modelKey);
         }
         catch
         {
            throw new ArgumentException(string.Format("The given model key [{0}] was not a valid key for [{1}].", 
               modelKeyString, typeof(T).FullName));
         }
      }
   }
}
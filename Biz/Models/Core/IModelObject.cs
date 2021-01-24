namespace MicroBlessingsApi.Biz.Models.Core
{
    /// <summary>
    /// The <c>IModelObject</c> is used to provide a standard way of identifying an object in the system
    /// through the use of the <see cref="ModelId"/> property.  Implementations of this interface should 
    /// model well known domain problems and in general map well to records in a database with a single 
    /// primary key.  
    /// <para>
    /// In general, <c>IModelObject</c>s should represent well known business objects in the system.  For
    /// example: Account, Person, Order, Club, Product, and Team are all examples of valid <c>IModelObject</c>s.  
    /// <c>IModelObject</c>s should stand on their own in the system.  In other words, they should not be
    /// represent relationships or complex attributes of another object.  Relationships between objects 
    /// are generally not considered <c>IModelObject</c>s because they do not represent an actual business 
    /// object in the system.  Relationships are things that are created and queried on through functions 
    /// in the Biz layer of the system.  Attributes may be valid classes in the Model layer, but should 
    /// not implement the <c>IModelObject</c> interface because they can't stand on their own.
    /// </para>
    /// </summary>
    /// <typeparam name="T">The model interface represented by this model object.</typeparam>
    /// <remarks>
    /// All <c>IModelObject</c> implementations in the service layer should be immutable.
    /// </remarks>
    public interface IModelObject<T> where T : class, IModelObject<T>
    {
        /// <summary>
        /// A unique identifier for the <see cref="IModelObject{T}"/> instance.
        /// </summary>
        ModelId<T> ModelId { get; }
    }
}
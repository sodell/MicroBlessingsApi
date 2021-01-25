namespace MicroBlessingsApi.Biz.Models.Core
{
    /// <summary>
    /// Represents a base model implementation that can be used as a base for 
    /// real model implementations.
    /// </summary>
    public class ModelObject<T> : IModelObject<T> where T:class, IModelObject<T>
    {
        /// <summary>
        /// Creates an instance of <c>ModelObject</c>.
        /// </summary>
        /// <param name="modelId">
        /// The Model ID.
        /// </param>
        protected ModelObject(ModelId<T> modelId)
        {
            //Verify.That(modelId, nameof(modelId)).IsNotNull();

            ModelId = modelId;
        }

        public ModelId<T> ModelId { get; private set; }
    }
}
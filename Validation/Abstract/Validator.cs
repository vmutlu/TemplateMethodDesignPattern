using System.Collections.Generic;

namespace Architecht_TemplateMethodDesignPattern.Validation.Abstract
{
    public abstract class Validator<TEntity> where TEntity : class, new()
    {
        public bool IsSuccess { get; protected set; }
        public List<string> Results { get; private set; }
        public TEntity Data { get; private set; }

        public Validator(TEntity entityModel)
        {
            this.Data = entityModel;
            this.Results = new List<string>();
            this.IsSuccess = true;
            this.OnValid();
        }

        protected abstract void OnValid();
    }
}

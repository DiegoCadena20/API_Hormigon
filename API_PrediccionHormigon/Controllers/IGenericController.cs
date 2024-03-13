using Microsoft.AspNetCore.Mvc;

namespace APIHormigon.Controllers
{
    public interface IGenericController<T>
    {
        ActionResult<T> Predecir([FromBody] T value);
    
    }
}

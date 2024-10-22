using Microsoft.AspNetCore.Mvc;
using API.Models;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private static List<Producto> productos = new List<Producto>
        {
            new Producto {Id=1, Nombre= "Producto 1", Precio=10},
            new Producto {Id=2, Nombre= "Producto 2", Precio=20},
        };

        //GET
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            var producto = productos.Find(p => p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        //POST
        [HttpPost]
        public ActionResult<Producto> Create([FromBody] Producto nuevoProducto)
        {
            productos.Add(nuevoProducto);
            return CreatedAtAction(nameof(Get), new {id = nuevoProducto.Id}, nuevoProducto);
        }

        //PUT
        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody] Producto productoEditado)
        {
            var producto = productos.Find(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            producto.Nombre = productoEditado.Nombre;
            producto.Precio = productoEditado.Precio;

            return NoContent();
        }

        //Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = productos.Find(p => p.Id == id);
            if(producto == null)
            {
                return NotFound();
            }
            productos.Remove(producto);
            return NoContent();

        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No se ha seleccionado ningun archivo");

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "upload");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var filePath = Path.Combine(folderPath, file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var fileUrl = $"{Request.Scheme}://{Request.Host}/upload/{file.FileName}";

            return Ok(new { fileUrl });


            
        }


       



    }
}

using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Model;

namespace ProjectAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private static readonly List<Product> Products = new();

    // GET: api/product
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(Products);
    }

    // GET: api/product/{id}
    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();

        return Ok(product);
    }

    // POST: api/product
    [HttpPost]
    public ActionResult<Product> Create(Product product)
    {
        product.Id = Products.Count > 0 ? Products.Max(p => p.Id) + 1 : 1;
        Products.Add(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    // PUT: api/product/{id}
    [HttpPut("{id}")]
    public IActionResult Update(int id, Product updated)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();

        product.Name = updated.Name;
        product.Price = updated.Price;

        return NoContent();
    }

    // DELETE: api/product/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();

        Products.Remove(product);
        return NoContent();
    }
}

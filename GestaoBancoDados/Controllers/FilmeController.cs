using GestaoBancoDados.Models.Domain.Entities;
using GestaoBancoDados.Models.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoBancoDados.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilmeController : ControllerBase
{
    private readonly IFilmeService _filmeService;

    public FilmeController(IFilmeService filmeService)
    {
        _filmeService = filmeService;
    }

    [HttpGet]
    public ActionResult GetAll()
    {
        try
        {
            var result = _filmeService.GetAll();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        try
        {
            var result = _filmeService.GetById(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public ActionResult Post([FromBody] Filme filme)
    {
        try
        {
            _filmeService.Create(filme);
            return Ok("Cadastro efetuado com sucesso");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpPut]
    public ActionResult Put([FromBody] Filme filme)
    {
        try
        {
            _filmeService.Update(filme);
            return Ok("Atualizacao efetuada com sucesso");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        try
        {
            _filmeService.Delete(id);
            return Ok("Filme excluido com sucesso");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

}

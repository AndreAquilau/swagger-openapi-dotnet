using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiResponse.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{


    /// <summary>
    /// Consulta cliente por ID
    /// </summary>
    /// <param name="id">Id do cliente exemplo: 1</param>
    /// <response code="200">Consulta Cliente</response>
    /// <response code="404">Cliente não encontrado</response>
    /// <response code="500">Oops! Não é possível pesquisar seu cliente no momento</response>
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponseCliente))]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    [Produces("application/json")]
    public ActionResult<ApiResponseCliente> GetCliente([FromQuery] int id)
    {
        return Ok();
    }
}


public class ApiResponseCliente
{
    /// <summary>
    /// ID do cliente
    /// </summary>
    /// <example>10</example>
    [Required]
    public required int Id { get; set; }

    /// <summary>
    /// Nome do cliente
    /// </summary>
    /// <example>Andre</example>
    public string Name { get; set; } = "Sem nome";

    /// <summary>
    /// Descrição do cliente
    /// </summary>
    /// <example>Mora no Brasil</example>
    public string Description { get; set; } = "Sem descrição";


    public ETipoPessoa TipoPessoa { get; set; }
}


/// <summary>
/// Tipo do Cliente: 1 - Fisica, 2 - Juridica
/// </summary>
/// <example>1</example>
public enum ETipoPessoa
{
    Fisica = 1,
    Juridica = 2,
}
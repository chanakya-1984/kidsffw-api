using Kidsffw.Contracts.Interfaces;
using Kidsffw.Models;
using Microsoft.AspNetCore.Mvc;

namespace kidsffw.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PartnerController : ControllerBase
{
    private readonly ILogger<PartnerController> _logger;
    private readonly IPartnerRepository _partnerRepository;

    public PartnerController(ILogger<PartnerController> logger, IPartnerRepository partnerRepository)
    {
        _logger = logger;
        _partnerRepository = partnerRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Partner partner)
    {
        await _partnerRepository.AddAsync(partner);
        return Ok(partner);
    }
}
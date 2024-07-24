using Microsoft.AspNetCore.Mvc;
using Run_AC_Identity.Interfaces;
using Run_AC_Identity.Models;

namespace Run_AC_Identity.Controllers;

[ApiController]
[Route("[controller]")]
public class MembersController: ControllerBase {
    private IMembersRepository _membersRepository;

    public MembersController(IMembersRepository membersRepository) {
        _membersRepository = membersRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Member>> GetMembers() {
        return await _membersRepository.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<Member?> GetMember(string id) {
        return await _membersRepository.GetAsync(id);
    }

    [HttpPost]
    public async Task<Member?> CreateMember(Member member) {
        return await _membersRepository.AddAsync(member);
    }

    [HttpPost]
    [Route("add-multiple")]
    public async Task<List<Member>> CreateMembersRange(List<Member> members) {
        return await _membersRepository.AddRange(members);
    }
}
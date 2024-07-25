using Microsoft.AspNetCore.Mvc;
using Run_AC_Identity.Interfaces;
using Run_AC_Identity.Models;

namespace Run_AC_Identity.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController: Controller {
    private IMembersRepository _membersRepository;

    public MembersController(IMembersRepository membersRepository) {
        _membersRepository = membersRepository;
    }

    [HttpGet("get-members")]
    
    public async Task<IEnumerable<Member>> GetMembers() {
        return await _membersRepository.GetAllAsync();
    }

    [HttpGet("get-member/{id}")]
    public async Task<Member?> GetMember(Guid id) {
        return await _membersRepository.GetAsync(id);
    }

    [HttpPost("create-member")]
    public async Task<Member?> CreateMember(Member member) {
        return await _membersRepository.AddAsync(member);
    }

    [HttpPost("add-multiple")]
    public async Task<List<Member>> CreateMembersRange(List<Member> members) {
        return await _membersRepository.AddRange(members);
    }

    [HttpGet("get-member-by-id-number/{idNumber}")]
    public async Task<Member?> GetMemberByIdNumber(string idNumber) {
        return await _membersRepository.SearchByIdNumber(idNumber);
    }
}
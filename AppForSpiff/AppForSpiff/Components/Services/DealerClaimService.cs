//mw
using AppForSpiff.Data;
using Microsoft.EntityFrameworkCore;


namespace AppForSpiff.Components.Services
{
    public class DealerClaimService
    {
        private readonly ApplicationDbContext _context;
        public DealerClaimService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string?> GetDealerCodeByUserIdAsync(string userid)
        {
            var dealerClaim=await _context.UserClaims
                .Where(c=>c.UserId == userid && c.ClaimType == "DealerCode")
                .Select(c=>c.ClaimValue)
                .FirstOrDefaultAsync();
            return dealerClaim;
        }
    }
}

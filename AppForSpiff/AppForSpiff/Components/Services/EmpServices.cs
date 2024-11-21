using Microsoft.EntityFrameworkCore;
using AppForSpiff.Data;
using System.Threading.Tasks;


namespace AppForSpiff.Components.Services
{
    public class EmpServices
    {
        private readonly AppForSpiffContext _dbContext;

        public EmpServices(AppForSpiffContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ChemicalsData[]> GetEmpDetailsAsync(DateTime StartDate, DateTime EndDate)
        {
            // Log the start and end dates passed to the method
            Console.WriteLine($"[INFO] Executing stored procedure with StartDate: {StartDate}, EndDate: {EndDate}");

            try
            {
                // Attempt to execute the stored procedure
                var result = await _dbContext.DisplayEmpRecords
                    .FromSqlRaw("EXEC dbo.spiff_Chemicals @startDate = {0}, @endDate = {1}", StartDate, EndDate)
                    .ToArrayAsync();

                // Log the number of records returned
                Console.WriteLine($"[INFO] Records returned: {result.Length}");

                // Log success if records are returned
                if (result.Length > 0)
                {
                    Console.WriteLine("[INFO] Successfully fetched data from stored procedure.");
                }
                else
                {
                    Console.WriteLine("[WARN] No records found for the specified date range.");
                }

                return result;
            }
            catch (Exception ex)
            {
                // Log the error message and stack trace for debugging
                Console.Error.WriteLine($"[ERROR] Failed to execute stored procedure: {ex.Message}");
                Console.Error.WriteLine($"[ERROR] Stack Trace: {ex.StackTrace}");

                return Array.Empty<ChemicalsData>();
            }
        }


    }
}

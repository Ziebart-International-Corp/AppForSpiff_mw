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
        public async Task<ChemAccData[]> GetChemAccAsync(string dealerCode, DateTime StartDate, DateTime EndDate)
        {
            // Log the start and end dates passed to the method
            Console.WriteLine($"[INFO] Executing stored procedure with StartDate: {StartDate}, EndDate: {EndDate}");

            try
            {
                // Attempt to execute the stored procedure
                var result = await _dbContext.DisplayChemAccRecords
                    .FromSqlRaw("EXEC dbo.spiff_Section1_Data @dealerCode = {0}, @startDate = {1}, @endDate = {2}", dealerCode, StartDate, EndDate)
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

                return Array.Empty<ChemAccData>();
            }
        }

        public async Task<ChemData[]> GetChemAsync(string dealerCode, DateTime StartDate, DateTime EndDate)
        {
            // Log the start and end dates passed to the method
            Console.WriteLine($"[INFO] Executing stored procedure with StartDate: {StartDate}, EndDate: {EndDate}");

            try
            {
                // Attempt to execute the stored procedure
                var result2 = await _dbContext.DisplayChemRecords
                    .FromSqlRaw("EXEC dbo.spiff_Section1_Calcs_Chem @dealerCode = {0}, @startDate = {1}, @endDate = {2}", dealerCode, StartDate, EndDate)
                    .ToArrayAsync();

                // Log the number of records returned
                Console.WriteLine($"[INFO] Records returned: {result2.Length}");

                // Log success if records are returned
                if (result2.Length > 0)
                {
                    Console.WriteLine("[INFO] Successfully fetched data from stored procedure.");
                }
                else
                {
                    Console.WriteLine("[WARN] No records found for the specified date range.");
                }

                return result2;
            }
            catch (Exception ex)
            {
                // Log the error message and stack trace for debugging
                Console.Error.WriteLine($"[ERROR] Failed to execute stored procedure: {ex.Message}");
                Console.Error.WriteLine($"[ERROR] Stack Trace: {ex.StackTrace}");

                return Array.Empty<ChemData>();
            }
        }

        public async Task<AccData[]> GetAccAsync(string dealerCode, DateTime StartDate, DateTime EndDate)
        {
            // Log the start and end dates passed to the method
            Console.WriteLine($"[INFO] Executing stored procedure with StartDate: {StartDate}, EndDate: {EndDate}");

            try
            {
                // Attempt to execute the stored procedure
                var result3 = await _dbContext.DisplayAccRecords
                    .FromSqlRaw("EXEC dbo.spiff_Section1_Calcs_Acc @dealerCode = {0}, @startDate = {1}, @endDate = {2}", dealerCode, StartDate, EndDate)
                    .ToArrayAsync();

                // Log the number of records returned
                Console.WriteLine($"[INFO] Records returned: {result3.Length}");

                // Log success if records are returned
                if (result3.Length > 0)
                {
                    Console.WriteLine("[INFO] Successfully fetched data from stored procedure.");
                }
                else
                {
                    Console.WriteLine("[WARN] No records found for the specified date range.");
                }

                return result3;
            }
            catch (Exception ex)
            {
                // Log the error message and stack trace for debugging
                Console.Error.WriteLine($"[ERROR] Failed to execute stored procedure: {ex.Message}");
                Console.Error.WriteLine($"[ERROR] Stack Trace: {ex.StackTrace}");

                return Array.Empty<AccData>();
            }
        }


        public async Task<PackagesData[]> GetPackagesAsync(string dealerCode, DateTime StartDate, DateTime EndDate)
        {
            // Log the start and end dates passed to the method
            Console.WriteLine($"[INFO] Executing stored procedure with StartDate: {StartDate}, EndDate: {EndDate}");

            try
            {
                // Attempt to execute the stored procedure
                var result4 = await _dbContext.DisplayPackagesRecords
                    .FromSqlRaw("EXEC dbo.spiff_Packages @dealerCode = {0}, @startDate = {1}, @endDate = {2}", dealerCode, StartDate, EndDate)
                    .ToArrayAsync();

                // Log the number of records returned
                Console.WriteLine($"[INFO] Records returned: {result4.Length}");

                // Log success if records are returned
                if (result4.Length > 0)
                {
                    Console.WriteLine("[INFO] Successfully fetched data from stored procedure.");
                }
                else
                {
                    Console.WriteLine("[WARN] No records found for the specified date range.");
                }

                return result4;
            }
            catch (Exception ex)
            {
                // Log the error message and stack trace for debugging
                Console.Error.WriteLine($"[ERROR] Failed to execute stored procedure: {ex.Message}");
                Console.Error.WriteLine($"[ERROR] Stack Trace: {ex.StackTrace}");

                return Array.Empty<PackagesData>();
            }
        }


        public async Task<ServiceCodesData[]> GetServiceCodesAsync(string dealerCode, DateTime StartDate, DateTime EndDate)
        {
            // Log the start and end dates passed to the method
            Console.WriteLine($"[INFO] Executing stored procedure with StartDate: {StartDate}, EndDate: {EndDate}");

            try
            {
                // Attempt to execute the stored procedure
                var result5 = await _dbContext.DisplayServiceCodesRecords
                    .FromSqlRaw("EXEC dbo.spiff_ServiceCodes @dealerCode = {0}, @startDate = {1}, @endDate = {2}", dealerCode, StartDate, EndDate)
                    .ToArrayAsync();

                // Log the number of records returned
                Console.WriteLine($"[INFO] Records returned: {result5.Length}");

                // Log success if records are returned
                if (result5.Length > 0)
                {
                    Console.WriteLine("[INFO] Successfully fetched data from stored procedure.");
                }
                else
                {
                    Console.WriteLine("[WARN] No records found for the specified date range.");
                }

                return result5;
            }
            catch (Exception ex)
            {
                // Log the error message and stack trace for debugging
                Console.Error.WriteLine($"[ERROR] Failed to execute stored procedure: {ex.Message}");
                Console.Error.WriteLine($"[ERROR] Stack Trace: {ex.StackTrace}");

                return Array.Empty<ServiceCodesData>();
            }
        }








    }
}

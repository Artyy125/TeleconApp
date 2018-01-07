using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleconApp.Models;

namespace TeleconApp.Interfaces
{
    public interface ISplicer
    {
        List<EmployeeModel> GetAllEmployees();
        List<VehicleModel> GetAllVehicles();
        List<NetworkModel> GetAllNetworks();
        List<EnclosureModel> GetAllEnclosures();
        int SaveSplicer(SplicerModel model);
        int SaveSplicerTest(SplicerModel model);
        int SaveSplicerTimesheet(SplicerModel model);
        SplicerModel GetSplicerPrepActivity(int employeeId);
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;
namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 车辆管理
    /// </summary>
    [Route("api/[controller]/[action]")]

    public class RegistrationController : Controller
    {
        public IRegistrationModel registration;
        public RegistrationController(IRegistrationModel _registration)
        {
            registration = _registration;
        }
        [HttpGet]
        public IActionResult GetRegistration(string FactoryPlateModel="", string LicensePlateNumber="", string LicensePlateName="", string SubordinateCompanies="")
        {
            return Ok(registration.GetRegistrations(FactoryPlateModel,LicensePlateNumber,LicensePlateName,SubordinateCompanies));
        }
    }
}

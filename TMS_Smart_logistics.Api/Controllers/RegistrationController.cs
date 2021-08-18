using Microsoft.AspNetCore.Mvc;
using TMS_Smart_logistics.IRepository;
namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 车辆管理
    /// </summary>
    [Route("api/[controller]/[action]")]

    public class RegistrationController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public IRegistrationModel registration;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_registration"></param>
        public RegistrationController(IRegistrationModel _registration)
        {
            registration = _registration;
        }
        /// <summary>
        /// 车辆管理显示
        /// </summary>
        /// <param name="FactoryPlateModel">车厂型号</param>
        /// <param name="LicensePlateNumber">车牌号</param>
        /// <param name="LicensePlateName">司机姓名</param>
        /// <param name="SubordinateCompanies">所属公司</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetRegistration(string FactoryPlateModel="", string LicensePlateNumber="", string LicensePlateName="", string SubordinateCompanies="")
        {

            return Ok(registration.GetRegistrations(FactoryPlateModel,LicensePlateNumber,LicensePlateName,SubordinateCompanies));
        }
    }
}

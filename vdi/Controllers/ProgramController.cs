using Microsoft.AspNetCore.Mvc;
using vdi.dto.Request;
using vdi.dto.Response;
using vdi.Helper;

namespace vdi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProgramController : Controller
    {

        [HttpPost("splitChar")]
        public SplitCharResponse splitChar(SplitCharRequest request) { 
            
            SplitCharResponse response = new SplitCharResponse();
            response.Output = ProgramHelper.SplitAndReverse(request.Input);
            return response;
        }


        [HttpPost("anagramCheck")]
        public int[] anagramCheck(AnagramRequest request) {

            return ProgramHelper.anagramChecker(request);
        }
        [HttpPost("discountCalculate")]

        public DiscountResponse discountResponse(DiscountRequest request) {

            var discount = ProgramHelper.CalculateDiscount(request.TipeCustomer, request.PointReward, request.TotalBelanja);

            DiscountResponse response = new DiscountResponse();
            response.TipeCustomer = request.TipeCustomer;
            response.TotalBelanja = request.TotalBelanja;
            response.PointReward = request.PointReward;
            response.Discount = (int) discount.discount;
            response.TotalBayar = (int) discount.totalPay;

           return response;
        }


        


    }
}

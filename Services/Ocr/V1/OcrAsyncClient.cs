using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ocr.V1.Model;

namespace HuaweiCloud.SDK.Ocr.V1
{
    public partial class OcrAsyncClient : Client
    {
        public static ClientBuilder<OcrAsyncClient> NewBuilder()
        {
            return new ClientBuilder<OcrAsyncClient>();
        }

        
        /// <summary>
        /// 智能分类识别
        /// </summary>
        public async Task<RecognizeAutoClassificationResponse> RecognizeAutoClassificationAsync(RecognizeAutoClassificationRequest recognizeAutoClassificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/auto-classification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeAutoClassificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeAutoClassificationResponse>(response);
        }
        
        /// <summary>
        /// 银行卡识别
        /// </summary>
        public async Task<RecognizeBankcardResponse> RecognizeBankcardAsync(RecognizeBankcardRequest recognizeBankcardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/bankcard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBankcardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeBankcardResponse>(response);
        }
        
        /// <summary>
        /// 名片识别
        /// </summary>
        public async Task<RecognizeBusinessCardResponse> RecognizeBusinessCardAsync(RecognizeBusinessCardRequest recognizeBusinessCardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/business-card",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBusinessCardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeBusinessCardResponse>(response);
        }
        
        /// <summary>
        /// 营业执照识别
        /// </summary>
        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseAsync(RecognizeBusinessLicenseRequest recognizeBusinessLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/business-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBusinessLicenseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeBusinessLicenseResponse>(response);
        }
        
        /// <summary>
        /// 驾驶证识别
        /// </summary>
        public async Task<RecognizeDriverLicenseResponse> RecognizeDriverLicenseAsync(RecognizeDriverLicenseRequest recognizeDriverLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/driver-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeDriverLicenseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeDriverLicenseResponse>(response);
        }
        
        /// <summary>
        /// 飞机行程单识别
        /// </summary>
        public async Task<RecognizeFlightItineraryResponse> RecognizeFlightItineraryAsync(RecognizeFlightItineraryRequest recognizeFlightItineraryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/flight-itinerary",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeFlightItineraryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeFlightItineraryResponse>(response);
        }
        
        /// <summary>
        /// 通用表格识别
        /// </summary>
        public async Task<RecognizeGeneralTableResponse> RecognizeGeneralTableAsync(RecognizeGeneralTableRequest recognizeGeneralTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/general-table",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeGeneralTableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeGeneralTableResponse>(response);
        }
        
        /// <summary>
        /// 通用文字识别
        /// </summary>
        public async Task<RecognizeGeneralTextResponse> RecognizeGeneralTextAsync(RecognizeGeneralTextRequest recognizeGeneralTextRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/general-text",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeGeneralTextRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeGeneralTextResponse>(response);
        }
        
        /// <summary>
        /// 手写文字识别
        /// </summary>
        public async Task<RecognizeHandwritingResponse> RecognizeHandwritingAsync(RecognizeHandwritingRequest recognizeHandwritingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/handwriting",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHandwritingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeHandwritingResponse>(response);
        }
        
        /// <summary>
        /// 身份证识别
        /// </summary>
        public async Task<RecognizeIdCardResponse> RecognizeIdCardAsync(RecognizeIdCardRequest recognizeIdCardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/id-card",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeIdCardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeIdCardResponse>(response);
        }
        
        /// <summary>
        /// 车牌识别
        /// </summary>
        public async Task<RecognizeLicensePlateResponse> RecognizeLicensePlateAsync(RecognizeLicensePlateRequest recognizeLicensePlateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/license-plate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeLicensePlateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeLicensePlateResponse>(response);
        }
        
        /// <summary>
        /// 机动车销售发票识别
        /// </summary>
        public async Task<RecognizeMvsInvoiceResponse> RecognizeMvsInvoiceAsync(RecognizeMvsInvoiceRequest recognizeMvsInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/mvs-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMvsInvoiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeMvsInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 护照识别
        /// </summary>
        public async Task<RecognizePassportResponse> RecognizePassportAsync(RecognizePassportRequest recognizePassportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/passport",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizePassportRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizePassportResponse>(response);
        }
        
        /// <summary>
        /// 定额发票识别
        /// </summary>
        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceAsync(RecognizeQuotaInvoiceRequest recognizeQuotaInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/quota-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeQuotaInvoiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeQuotaInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 出租车发票识别
        /// </summary>
        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceAsync(RecognizeTaxiInvoiceRequest recognizeTaxiInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/taxi-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTaxiInvoiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeTaxiInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 车辆通行费发票识别
        /// </summary>
        public async Task<RecognizeTollInvoiceResponse> RecognizeTollInvoiceAsync(RecognizeTollInvoiceRequest recognizeTollInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/toll-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTollInvoiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeTollInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 火车票识别
        /// </summary>
        public async Task<RecognizeTrainTicketResponse> RecognizeTrainTicketAsync(RecognizeTrainTicketRequest recognizeTrainTicketRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/train-ticket",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTrainTicketRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeTrainTicketResponse>(response);
        }
        
        /// <summary>
        /// 道路运输证识别
        /// </summary>
        public async Task<RecognizeTransportationLicenseResponse> RecognizeTransportationLicenseAsync(RecognizeTransportationLicenseRequest recognizeTransportationLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/transportation-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTransportationLicenseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeTransportationLicenseResponse>(response);
        }
        
        /// <summary>
        /// 增值税发票识别
        /// </summary>
        public async Task<RecognizeVatInvoiceResponse> RecognizeVatInvoiceAsync(RecognizeVatInvoiceRequest recognizeVatInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vat-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVatInvoiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeVatInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 行驶证识别
        /// </summary>
        public async Task<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseAsync(RecognizeVehicleLicenseRequest recognizeVehicleLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vehicle-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVehicleLicenseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeVehicleLicenseResponse>(response);
        }
        
        /// <summary>
        /// 网络图片识别
        /// </summary>
        public async Task<RecognizeWebImageResponse> RecognizeWebImageAsync(RecognizeWebImageRequest recognizeWebImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/web-image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeWebImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeWebImageResponse>(response);
        }
        
        /// <summary>
        /// VIN码识别
        /// </summary>
        public async Task<RecognizeVinResponse> RecognizeVinAsync(RecognizeVinRequest recognizeVinRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vin",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVinRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeVinResponse>(response);
        }
        
    }
}
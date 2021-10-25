using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ocr.V1.Model;

namespace HuaweiCloud.SDK.Ocr.V1
{
    public partial class OcrClient : Client
    {
        public static ClientBuilder<OcrClient> NewBuilder()
        {
            return new ClientBuilder<OcrClient>();
        }

        
        /// <summary>
        /// 智能分类识别
        /// </summary>
        public RecognizeAutoClassificationResponse RecognizeAutoClassification(RecognizeAutoClassificationRequest recognizeAutoClassificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/auto-classification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeAutoClassificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeAutoClassificationResponse>(response);
        }
        
        /// <summary>
        /// 银行卡识别
        /// </summary>
        public RecognizeBankcardResponse RecognizeBankcard(RecognizeBankcardRequest recognizeBankcardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/bankcard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBankcardRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeBankcardResponse>(response);
        }
        
        /// <summary>
        /// 名片识别
        /// </summary>
        public RecognizeBusinessCardResponse RecognizeBusinessCard(RecognizeBusinessCardRequest recognizeBusinessCardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/business-card",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBusinessCardRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeBusinessCardResponse>(response);
        }
        
        /// <summary>
        /// 营业执照识别
        /// </summary>
        public RecognizeBusinessLicenseResponse RecognizeBusinessLicense(RecognizeBusinessLicenseRequest recognizeBusinessLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/business-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBusinessLicenseRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeBusinessLicenseResponse>(response);
        }
        
        /// <summary>
        /// 驾驶证识别
        /// </summary>
        public RecognizeDriverLicenseResponse RecognizeDriverLicense(RecognizeDriverLicenseRequest recognizeDriverLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/driver-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeDriverLicenseRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeDriverLicenseResponse>(response);
        }
        
        /// <summary>
        /// 财务报表识别
        /// </summary>
        public RecognizeFinancialStatementResponse RecognizeFinancialStatement(RecognizeFinancialStatementRequest recognizeFinancialStatementRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/financial-statement",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeFinancialStatementRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeFinancialStatementResponse>(response);
        }
        
        /// <summary>
        /// 飞机行程单识别
        /// </summary>
        public RecognizeFlightItineraryResponse RecognizeFlightItinerary(RecognizeFlightItineraryRequest recognizeFlightItineraryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/flight-itinerary",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeFlightItineraryRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeFlightItineraryResponse>(response);
        }
        
        /// <summary>
        /// 通用表格识别
        /// </summary>
        public RecognizeGeneralTableResponse RecognizeGeneralTable(RecognizeGeneralTableRequest recognizeGeneralTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/general-table",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeGeneralTableRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeGeneralTableResponse>(response);
        }
        
        /// <summary>
        /// 通用文字识别
        /// </summary>
        public RecognizeGeneralTextResponse RecognizeGeneralText(RecognizeGeneralTextRequest recognizeGeneralTextRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/general-text",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeGeneralTextRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeGeneralTextResponse>(response);
        }
        
        /// <summary>
        /// 手写文字识别
        /// </summary>
        public RecognizeHandwritingResponse RecognizeHandwriting(RecognizeHandwritingRequest recognizeHandwritingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/handwriting",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHandwritingRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeHandwritingResponse>(response);
        }
        
        /// <summary>
        /// 身份证识别
        /// </summary>
        public RecognizeIdCardResponse RecognizeIdCard(RecognizeIdCardRequest recognizeIdCardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/id-card",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeIdCardRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeIdCardResponse>(response);
        }
        
        /// <summary>
        /// 保险单识别
        /// </summary>
        public RecognizeInsurancePolicyResponse RecognizeInsurancePolicy(RecognizeInsurancePolicyRequest recognizeInsurancePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/insurance-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeInsurancePolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeInsurancePolicyResponse>(response);
        }
        
        /// <summary>
        /// 发票验真
        /// </summary>
        public RecognizeInvoiceVerificationResponse RecognizeInvoiceVerification(RecognizeInvoiceVerificationRequest recognizeInvoiceVerificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/invoice-verification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeInvoiceVerificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeInvoiceVerificationResponse>(response);
        }
        
        /// <summary>
        /// 车牌识别
        /// </summary>
        public RecognizeLicensePlateResponse RecognizeLicensePlate(RecognizeLicensePlateRequest recognizeLicensePlateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/license-plate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeLicensePlateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeLicensePlateResponse>(response);
        }
        
        /// <summary>
        /// 机动车销售发票识别
        /// </summary>
        public RecognizeMvsInvoiceResponse RecognizeMvsInvoice(RecognizeMvsInvoiceRequest recognizeMvsInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/mvs-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMvsInvoiceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeMvsInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 护照识别
        /// </summary>
        public RecognizePassportResponse RecognizePassport(RecognizePassportRequest recognizePassportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/passport",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizePassportRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizePassportResponse>(response);
        }
        
        /// <summary>
        /// 从业资格证识别
        /// </summary>
        public RecognizeQualificationCertificateResponse RecognizeQualificationCertificate(RecognizeQualificationCertificateRequest recognizeQualificationCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/transportation-qualification-certificate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeQualificationCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeQualificationCertificateResponse>(response);
        }
        
        /// <summary>
        /// 定额发票识别
        /// </summary>
        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoice(RecognizeQuotaInvoiceRequest recognizeQuotaInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/quota-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeQuotaInvoiceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeQuotaInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 出租车发票识别
        /// </summary>
        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoice(RecognizeTaxiInvoiceRequest recognizeTaxiInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/taxi-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTaxiInvoiceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeTaxiInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 车辆通行费发票识别
        /// </summary>
        public RecognizeTollInvoiceResponse RecognizeTollInvoice(RecognizeTollInvoiceRequest recognizeTollInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/toll-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTollInvoiceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeTollInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 火车票识别
        /// </summary>
        public RecognizeTrainTicketResponse RecognizeTrainTicket(RecognizeTrainTicketRequest recognizeTrainTicketRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/train-ticket",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTrainTicketRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeTrainTicketResponse>(response);
        }
        
        /// <summary>
        /// 道路运输证识别
        /// </summary>
        public RecognizeTransportationLicenseResponse RecognizeTransportationLicense(RecognizeTransportationLicenseRequest recognizeTransportationLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/transportation-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTransportationLicenseRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeTransportationLicenseResponse>(response);
        }
        
        /// <summary>
        /// 增值税发票识别
        /// </summary>
        public RecognizeVatInvoiceResponse RecognizeVatInvoice(RecognizeVatInvoiceRequest recognizeVatInvoiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vat-invoice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVatInvoiceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeVatInvoiceResponse>(response);
        }
        
        /// <summary>
        /// 行驶证识别
        /// </summary>
        public RecognizeVehicleLicenseResponse RecognizeVehicleLicense(RecognizeVehicleLicenseRequest recognizeVehicleLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vehicle-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVehicleLicenseRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeVehicleLicenseResponse>(response);
        }
        
        /// <summary>
        /// 网络图片识别
        /// </summary>
        public RecognizeWebImageResponse RecognizeWebImage(RecognizeWebImageRequest recognizeWebImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/web-image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeWebImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeWebImageResponse>(response);
        }
        
        /// <summary>
        /// VIN码识别
        /// </summary>
        public RecognizeVinResponse RecognizeVin(RecognizeVinRequest recognizeVinRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vin",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVinRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeVinResponse>(response);
        }
        
    }
}
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
        ///
        /// 检测定位图片上指定要识别的票证（票据、证件或其他文字载体），并对其进行结构化识别。接口以列表形式返回图片上要识别票证的位置坐标、结构化识别的内容以及对应的类别。
        /// 
        /// 计费次数说明：
        /// 
        /// 只对识别成功的票证进行计费，识别失败的票证不计费。例如图片中包含三张票证，有两张识别成功，一张识别失败，此时接口计费两次。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别银行卡上的关键文字信息，并返回识别的结构化结果。
        /// 
        /// 说明：
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别名片图片上的文字信息，并返回识别的结构化结果。支持对多种不同版式名片进行结构化信息提取。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别营业执照首页图片中的文字信息，并返回识别的结构化结果。
        /// 
        /// 说明： 
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 智利身份证识别
        ///
        /// 识别智利身份证图片中的文字内容，并返回识别的结构化结果。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeChileIdCardResponse> RecognizeChileIdCardAsync(RecognizeChileIdCardRequest recognizeChileIdCardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/chile-id-card",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeChileIdCardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeChileIdCardResponse>(response);
        }
        
        /// <summary>
        /// 驾驶证识别
        ///
        /// 识别用户上传的驾驶证图片（或者用户提供的华为云上OBS的驾驶证图片文件的URL）中主页与副页的文字内容，并将识别的结果返回给用户。
        /// 
        /// 说明： 
        /// 
        /// 如果图片中包含多张卡证票据，请调用智能分类识别服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 财务报表识别
        ///
        /// 识别用户上传的表格图片中的文字内容，并将识别的结果返回给用户。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeFinancialStatementResponse> RecognizeFinancialStatementAsync(RecognizeFinancialStatementRequest recognizeFinancialStatementRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/financial-statement",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeFinancialStatementRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeFinancialStatementResponse>(response);
        }
        
        /// <summary>
        /// 飞机行程单识别
        ///
        /// 识别飞机行程单中的文字信息，并返回识别的结构化结果。
        /// 
        /// 说明：
        /// 
        /// 如果图片中包含多张卡证票据，请调用智能分类识别服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别用于识别用户上传的通用表格图片（或者用户提供的华为云上OBS的通用表格图片文件的URL）中的文字内容，并将识别的结果返回给用户。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别图片上的文字信息，返回识别的文字和坐标。支持扫描文件、电子文档、书籍、票据和表单等多种场景的文字识别。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别文档中的手写文字信息，并将识别的结构化结果返回给用户。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 防疫健康码识别
        ///
        /// 识别防疫健康码中的文字信息，并将识别的结构化结果返回给用户。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeHealthCodeResponse> RecognizeHealthCodeAsync(RecognizeHealthCodeRequest recognizeHealthCodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/health-code",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHealthCodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeHealthCodeResponse>(response);
        }
        
        /// <summary>
        /// 身份证识别
        ///
        /// 识别身份证图片中的文字内容，并将识别的结果返回给用户。
        /// 
        /// 说明： 
        /// 
        /// 身份证识别支持中华人民共和国居民身份证识别。
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 保险单识别
        ///
        /// 识别保险单图片上的文字信息，并将识别的结构化结果返回给用户。支持对多板式保险单的扫描图片及手机照片进行结构化信息提取。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeInsurancePolicyResponse> RecognizeInsurancePolicyAsync(RecognizeInsurancePolicyRequest recognizeInsurancePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/insurance-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeInsurancePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeInsurancePolicyResponse>(response);
        }
        
        /// <summary>
        /// 发票验真
        ///
        /// 发票验真服务支持9种增值税发票的信息核验，包括增值税专用发票、增值税普通发票、增值税普通发票（卷式）、增值税电子专用发票、增值税电子普通发票、增值税电子普通发票（通行费）、二手车销售统一发票、机动车销售统一发票、区块链电子发票，支持返回票面的全部信息。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeInvoiceVerificationResponse> RecognizeInvoiceVerificationAsync(RecognizeInvoiceVerificationRequest recognizeInvoiceVerificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/invoice-verification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeInvoiceVerificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeInvoiceVerificationResponse>(response);
        }
        
        /// <summary>
        /// 车牌识别
        ///
        /// 识别输入图片中的车牌信息，并返回其坐标和内容。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别机动车销售发票图片中的文字内容，并将识别的结果返回给用户。
        /// 
        /// 说明：
        /// 
        /// 该增值税发票仅限于中华人民共和国境内使用的增值税发票。
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 缅文驾驶证识别
        ///
        /// 识别缅甸驾驶证中的文字信息，并返回识别的结构化结果。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeMyanmarDriverLicenseResponse> RecognizeMyanmarDriverLicenseAsync(RecognizeMyanmarDriverLicenseRequest recognizeMyanmarDriverLicenseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/myanmar-driver-license",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMyanmarDriverLicenseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeMyanmarDriverLicenseResponse>(response);
        }
        
        /// <summary>
        /// 缅文身份证识别
        ///
        /// 识别缅文身份证中的文字信息，并返回识别的结构化结果。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeMyanmarIdcardResponse> RecognizeMyanmarIdcardAsync(RecognizeMyanmarIdcardRequest recognizeMyanmarIdcardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/myanmar-id-card",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMyanmarIdcardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeMyanmarIdcardResponse>(response);
        }
        
        /// <summary>
        /// 护照识别
        ///
        /// 识别用户上传的护照首页图片中的文字信息，并返回识别的结构化结果。当前版本支持中国护照的全字段识别。外国护照支持护照下方两行国际标准化的机读码识别，并可从中提取6-7个关键字段信息。
        /// 
        /// 说明：
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 从业资格证识别
        ///
        /// 识别道路运输从业资格证上的关键文字信息，并返回识别的结构化结果。
        /// 
        /// 说明：
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeQualificationCertificateResponse> RecognizeQualificationCertificateAsync(RecognizeQualificationCertificateRequest recognizeQualificationCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/transportation-qualification-certificate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeQualificationCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeQualificationCertificateResponse>(response);
        }
        
        /// <summary>
        /// 定额发票识别
        ///
        /// 识别定额发票中的文字信息，并返回识别的结构化结果。
        /// 
        /// 说明： 
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别出租车发票中的文字信息，并返回识别的结构化结果。
        /// 
        /// 说明：
        /// 
        /// 如果图片中包含多张卡证票据，请调用智能分类识别服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 泰文身份证识别
        ///
        /// 识别泰国身份证中的文字信息，并返回识别的结构化结果。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeThailandIdcardResponse> RecognizeThailandIdcardAsync(RecognizeThailandIdcardRequest recognizeThailandIdcardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/thailand-id-card",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeThailandIdcardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeThailandIdcardResponse>(response);
        }
        
        /// <summary>
        /// 泰国车牌识别
        ///
        /// 识别泰国车牌图片中的车牌信息，并返回识别的结构化结果。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeThailandLicensePlateResponse> RecognizeThailandLicensePlateAsync(RecognizeThailandLicensePlateRequest recognizeThailandLicensePlateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/thailand-license-plate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeThailandLicensePlateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeThailandLicensePlateResponse>(response);
        }
        
        /// <summary>
        /// 车辆通行费发票识别
        ///
        /// 识别车辆通行费发票中的文字信息，并返回识别的结构化结果。
        /// 
        /// 说明：
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别火车票中的文字信息，并返回识别的结构化结果。
        /// 
        /// 说明：
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别道路运输证首页中的文字信息，并返回识别的结构化结果。
        /// 
        /// 说明： 如果图片中包含多张卡证票据，请调用智能分类识别服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别用户上传的增值税发票图片（或者用户提供的华为云上OBS的增值税发票图片文件的URL）中的文字内容，并将识别的结果返回给用户。
        /// 
        /// 说明：
        /// 
        /// 该增值税发票仅限于中华人民共和国境内使用的增值税发票。
        /// 
        /// 如果图片中包含多张卡证票据，请调用智能分类识别服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别用户上传的行驶证图片（或者用户提供的华为云上OBS的行驶证图片文件的URL）中主页和副页的文字内容，并将识别的结果返回给用户。
        /// 
        /// 说明：
        /// 
        /// 如果图片中包含多张卡证票据，请调用智能分类识别服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 电子面单识别
        ///
        /// 识别用户上传的韵达电子面单图片中的文字内容，并将识别的结果以json格式返回给用户。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeWaybillElectronicResponse> RecognizeWaybillElectronicAsync(RecognizeWaybillElectronicRequest recognizeWaybillElectronicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/waybill-electronic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeWaybillElectronicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeWaybillElectronicResponse>(response);
        }
        
        /// <summary>
        /// 网络图片识别
        ///
        /// 识别网络图片中的文字内容，并返回识别的结构化结果。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 识别图片中的车架号信息，并将识别结果返回给用户。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
using System;
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
        /// 承兑汇票识别
        ///
        /// 识别承兑汇票中的关键信息, 并以json格式返回结构化结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeAcceptanceBillResponse> RecognizeAcceptanceBillAsync(RecognizeAcceptanceBillRequest recognizeAcceptanceBillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/acceptance-bill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeAcceptanceBillRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeAcceptanceBillResponse>(response);
        }

        public AsyncInvoker<RecognizeAcceptanceBillResponse> RecognizeAcceptanceBillAsyncInvoker(RecognizeAcceptanceBillRequest recognizeAcceptanceBillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/acceptance-bill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeAcceptanceBillRequest);
            return new AsyncInvoker<RecognizeAcceptanceBillResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeAcceptanceBillResponse>);
        }
        
        /// <summary>
        /// 智能分类识别
        ///
        /// 检测定位图片上指定要识别的票证（票据、证件或其他文字载体），并对其进行结构化识别。接口以列表形式返回图片上要识别票证的位置坐标、结构化识别的内容以及对应的类别。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section3)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 计费次数说明：
        /// 只对识别成功的票证进行计费，识别失败的票证不计费。例如图片中包含三张票证，有两张识别成功，一张识别失败，此时接口计费两次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeAutoClassificationResponse> RecognizeAutoClassificationAsync(RecognizeAutoClassificationRequest recognizeAutoClassificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/auto-classification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeAutoClassificationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeAutoClassificationResponse>(response);
        }

        public AsyncInvoker<RecognizeAutoClassificationResponse> RecognizeAutoClassificationAsyncInvoker(RecognizeAutoClassificationRequest recognizeAutoClassificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/auto-classification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeAutoClassificationRequest);
            return new AsyncInvoker<RecognizeAutoClassificationResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeAutoClassificationResponse>);
        }
        
        /// <summary>
        /// 银行卡识别
        ///
        /// 识别银行卡上的关键文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section9)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明：
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeBankcardResponse> RecognizeBankcardAsync(RecognizeBankcardRequest recognizeBankcardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/bankcard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBankcardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeBankcardResponse>(response);
        }

        public AsyncInvoker<RecognizeBankcardResponse> RecognizeBankcardAsyncInvoker(RecognizeBankcardRequest recognizeBankcardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/bankcard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBankcardRequest);
            return new AsyncInvoker<RecognizeBankcardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeBankcardResponse>);
        }
        
        /// <summary>
        /// 名片识别
        ///
        /// 识别名片图片上的文字信息，并返回识别的结构化结果。支持对多种不同版式名片进行结构化信息提取。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section13)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeBusinessCardResponse> RecognizeBusinessCardAsync(RecognizeBusinessCardRequest recognizeBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/business-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBusinessCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeBusinessCardResponse>(response);
        }

        public AsyncInvoker<RecognizeBusinessCardResponse> RecognizeBusinessCardAsyncInvoker(RecognizeBusinessCardRequest recognizeBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/business-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBusinessCardRequest);
            return new AsyncInvoker<RecognizeBusinessCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeBusinessCardResponse>);
        }
        
        /// <summary>
        /// 营业执照识别
        ///
        /// 识别营业执照首页图片中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section10)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// 说明： 
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseAsync(RecognizeBusinessLicenseRequest recognizeBusinessLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/business-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBusinessLicenseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeBusinessLicenseResponse>(response);
        }

        public AsyncInvoker<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseAsyncInvoker(RecognizeBusinessLicenseRequest recognizeBusinessLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/business-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeBusinessLicenseRequest);
            return new AsyncInvoker<RecognizeBusinessLicenseResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeBusinessLicenseResponse>);
        }
        
        /// <summary>
        /// 柬文身份证识别
        ///
        /// 识别柬文身份证图片中的文字内容，并将识别的结构化结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeCambodianIdCardResponse> RecognizeCambodianIdCardAsync(RecognizeCambodianIdCardRequest recognizeCambodianIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/cambodian-idcard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeCambodianIdCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeCambodianIdCardResponse>(response);
        }

        public AsyncInvoker<RecognizeCambodianIdCardResponse> RecognizeCambodianIdCardAsyncInvoker(RecognizeCambodianIdCardRequest recognizeCambodianIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/cambodian-idcard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeCambodianIdCardRequest);
            return new AsyncInvoker<RecognizeCambodianIdCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeCambodianIdCardResponse>);
        }
        
        /// <summary>
        /// 智利身份证识别
        ///
        /// 识别智利身份证图片中的文字内容，并返回识别的结构化结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeChileIdCardResponse> RecognizeChileIdCardAsync(RecognizeChileIdCardRequest recognizeChileIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/chile-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeChileIdCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeChileIdCardResponse>(response);
        }

        public AsyncInvoker<RecognizeChileIdCardResponse> RecognizeChileIdCardAsyncInvoker(RecognizeChileIdCardRequest recognizeChileIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/chile-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeChileIdCardRequest);
            return new AsyncInvoker<RecognizeChileIdCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeChileIdCardResponse>);
        }
        
        /// <summary>
        /// 哥伦比亚身份证识别
        ///
        /// 识别哥伦比亚身份证中的文字信息，并将识别的结构化结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeColombiaIdCardResponse> RecognizeColombiaIdCardAsync(RecognizeColombiaIdCardRequest recognizeColombiaIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/colombia-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeColombiaIdCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeColombiaIdCardResponse>(response);
        }

        public AsyncInvoker<RecognizeColombiaIdCardResponse> RecognizeColombiaIdCardAsyncInvoker(RecognizeColombiaIdCardRequest recognizeColombiaIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/colombia-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeColombiaIdCardRequest);
            return new AsyncInvoker<RecognizeColombiaIdCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeColombiaIdCardResponse>);
        }
        
        /// <summary>
        /// 驾驶证识别
        ///
        /// 识别用户上传的驾驶证图片（或者用户提供的华为云上OBS的驾驶证图片文件的URL）中主页与副页的文字内容，并将识别的结果返回给用户。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section6)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// 说明： 
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeDriverLicenseResponse> RecognizeDriverLicenseAsync(RecognizeDriverLicenseRequest recognizeDriverLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/driver-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeDriverLicenseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeDriverLicenseResponse>(response);
        }

        public AsyncInvoker<RecognizeDriverLicenseResponse> RecognizeDriverLicenseAsyncInvoker(RecognizeDriverLicenseRequest recognizeDriverLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/driver-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeDriverLicenseRequest);
            return new AsyncInvoker<RecognizeDriverLicenseResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeDriverLicenseResponse>);
        }
        
        /// <summary>
        /// 往来港澳台通行证识别
        ///
        /// 识别往来港澳台证件图片中的文字内容，并将识别的结构化结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeExitEntryPermitResponse> RecognizeExitEntryPermitAsync(RecognizeExitEntryPermitRequest recognizeExitEntryPermitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/exit-entry-permit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeExitEntryPermitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeExitEntryPermitResponse>(response);
        }

        public AsyncInvoker<RecognizeExitEntryPermitResponse> RecognizeExitEntryPermitAsyncInvoker(RecognizeExitEntryPermitRequest recognizeExitEntryPermitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/exit-entry-permit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeExitEntryPermitRequest);
            return new AsyncInvoker<RecognizeExitEntryPermitResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeExitEntryPermitResponse>);
        }
        
        /// <summary>
        /// 财务报表识别
        ///
        /// 识别用户上传的表格图片中的文字内容，并将识别的结果返回给用户。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section24)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeFinancialStatementResponse> RecognizeFinancialStatementAsync(RecognizeFinancialStatementRequest recognizeFinancialStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/financial-statement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeFinancialStatementRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeFinancialStatementResponse>(response);
        }

        public AsyncInvoker<RecognizeFinancialStatementResponse> RecognizeFinancialStatementAsyncInvoker(RecognizeFinancialStatementRequest recognizeFinancialStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/financial-statement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeFinancialStatementRequest);
            return new AsyncInvoker<RecognizeFinancialStatementResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeFinancialStatementResponse>);
        }
        
        /// <summary>
        /// 飞机行程单识别
        ///
        /// 识别飞机行程单中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section20)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明：
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeFlightItineraryResponse> RecognizeFlightItineraryAsync(RecognizeFlightItineraryRequest recognizeFlightItineraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/flight-itinerary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeFlightItineraryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeFlightItineraryResponse>(response);
        }

        public AsyncInvoker<RecognizeFlightItineraryResponse> RecognizeFlightItineraryAsyncInvoker(RecognizeFlightItineraryRequest recognizeFlightItineraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/flight-itinerary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeFlightItineraryRequest);
            return new AsyncInvoker<RecognizeFlightItineraryResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeFlightItineraryResponse>);
        }
        
        /// <summary>
        /// 通用表格识别
        ///
        /// 用于识别用户上传的通用表格图片（或者用户提供的华为云上OBS的通用表格图片文件的URL）中的文字内容，并将识别的结果返回给用户。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section0)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeGeneralTableResponse> RecognizeGeneralTableAsync(RecognizeGeneralTableRequest recognizeGeneralTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/general-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeGeneralTableRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeGeneralTableResponse>(response);
        }

        public AsyncInvoker<RecognizeGeneralTableResponse> RecognizeGeneralTableAsyncInvoker(RecognizeGeneralTableRequest recognizeGeneralTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/general-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeGeneralTableRequest);
            return new AsyncInvoker<RecognizeGeneralTableResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeGeneralTableResponse>);
        }
        
        /// <summary>
        /// 通用文字识别
        ///
        /// 识别图片上的文字信息，返回识别的文字和坐标。支持扫描文件、电子文档、书籍、票据和表单等多种场景的文字识别。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section1)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeGeneralTextResponse> RecognizeGeneralTextAsync(RecognizeGeneralTextRequest recognizeGeneralTextRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/general-text", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeGeneralTextRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeGeneralTextResponse>(response);
        }

        public AsyncInvoker<RecognizeGeneralTextResponse> RecognizeGeneralTextAsyncInvoker(RecognizeGeneralTextRequest recognizeGeneralTextRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/general-text", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeGeneralTextRequest);
            return new AsyncInvoker<RecognizeGeneralTextResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeGeneralTextResponse>);
        }
        
        /// <summary>
        /// 手写文字识别
        ///
        /// 识别文档中的手写文字信息，并将识别的结构化结果返回给用户。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section4)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeHandwritingResponse> RecognizeHandwritingAsync(RecognizeHandwritingRequest recognizeHandwritingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/handwriting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHandwritingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeHandwritingResponse>(response);
        }

        public AsyncInvoker<RecognizeHandwritingResponse> RecognizeHandwritingAsyncInvoker(RecognizeHandwritingRequest recognizeHandwritingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/handwriting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHandwritingRequest);
            return new AsyncInvoker<RecognizeHandwritingResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeHandwritingResponse>);
        }
        
        /// <summary>
        /// 防疫健康码识别
        ///
        /// 支持对全国各地区不同版式的防疫健康码、核酸检测记录、行程卡中的14个关键字段进行结构化识别；支持识别4种健康码颜色，包括绿码、黄码、红码、灰码；支持返回各个关键字段的置信度，以便提高人工校验效率。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section26)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeHealthCodeResponse> RecognizeHealthCodeAsync(RecognizeHealthCodeRequest recognizeHealthCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/health-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHealthCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeHealthCodeResponse>(response);
        }

        public AsyncInvoker<RecognizeHealthCodeResponse> RecognizeHealthCodeAsyncInvoker(RecognizeHealthCodeRequest recognizeHealthCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/health-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHealthCodeRequest);
            return new AsyncInvoker<RecognizeHealthCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeHealthCodeResponse>);
        }
        
        /// <summary>
        /// 香港身份证识别
        ///
        /// 识别香港身份证中的文字内容，并将识别的结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeHkIdCardResponse> RecognizeHkIdCardAsync(RecognizeHkIdCardRequest recognizeHkIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/hk-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHkIdCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeHkIdCardResponse>(response);
        }

        public AsyncInvoker<RecognizeHkIdCardResponse> RecognizeHkIdCardAsyncInvoker(RecognizeHkIdCardRequest recognizeHkIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/hk-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeHkIdCardRequest);
            return new AsyncInvoker<RecognizeHkIdCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeHkIdCardResponse>);
        }
        
        /// <summary>
        /// 身份证识别
        ///
        /// 识别身份证图片中的文字内容，并将识别的结果返回给用户。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section5)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// 说明： 
        /// 
        /// 身份证识别支持中华人民共和国居民身份证识别。
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeIdCardResponse> RecognizeIdCardAsync(RecognizeIdCardRequest recognizeIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeIdCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeIdCardResponse>(response);
        }

        public AsyncInvoker<RecognizeIdCardResponse> RecognizeIdCardAsyncInvoker(RecognizeIdCardRequest recognizeIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeIdCardRequest);
            return new AsyncInvoker<RecognizeIdCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeIdCardResponse>);
        }
        
        /// <summary>
        /// 通用证件识别
        ///
        /// 识别身份证件图像，并将识别的结构化结果返回给用户。支持多个国家/地区的身份证、驾驶证和护照，具体国家/地区和证件列表详见表1国家/地区和证件列表。
        /// 
        /// **表1国家/地区和证件列表**
        /// 
        /// | 国家/地区  | 英文名称    | 国家/地区代码 country_region | 支持证件类型 id_type      |
        /// | - -- -- -- -- - | - -- -- -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- |
        /// | 越南       | Vietnam     | VNM                          | PP、DL、ID                |
        /// | 印度       | India       | IND                          | PP                        |
        /// | 菲律宾     | Philippines | PHL                          | PP、DL、ID（仅支持UUMID） |
        /// | 阿尔巴尼亚 | Albania     | ALB                          | PP、DL、ID                |
        /// | 巴西       | BRAZIL      | BRA                          | PP                        |
        /// | 印度尼西亚 | INDONESIA   | IDN                          | PP                        |
        /// | 马来西亚   | MALAYSIA    | MYS                          | PP                        |
        /// | 尼日利亚   | NIGERIA     | NGA                          | PP                        |
        /// | 巴基斯坦   | PAKISTAN    | PAK                          | PP                        |
        /// | 俄罗斯     | RUSSIA      | RUS                          | PP（仅支持国际标准版本）  |
        /// | 中国台湾   | TAIWAN      | TWN                          | PP                        |
        /// | 乌克兰     | UKRAINE     | UKR                          | PP                        |
        /// | 泰国       | THAILAND    | THA                          | ID、PP                    |
        /// | 智利       | CHILE       | CHL                          | ID、PP                    |
        /// | 中国香港   | HONGKONG    | HKG                          | ID                        |
        /// 
        /// - PP: passport,国际护照
        /// - DL: driving license,驾驶证
        /// - ID: identification card,各国颁发的身份证类型证件，比如身份证、选民证、社保卡等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeIdDocumentResponse> RecognizeIdDocumentAsync(RecognizeIdDocumentRequest recognizeIdDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/id-document", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeIdDocumentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeIdDocumentResponse>(response);
        }

        public AsyncInvoker<RecognizeIdDocumentResponse> RecognizeIdDocumentAsyncInvoker(RecognizeIdDocumentRequest recognizeIdDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/id-document", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeIdDocumentRequest);
            return new AsyncInvoker<RecognizeIdDocumentResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeIdDocumentResponse>);
        }
        
        /// <summary>
        /// 保险单识别
        ///
        /// 识别保险单图片上的文字信息，并将识别的结构化结果返回给用户。支持对多种版式保险单的扫描图片及手机照片进行结构化信息提取。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section23)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeInsurancePolicyResponse> RecognizeInsurancePolicyAsync(RecognizeInsurancePolicyRequest recognizeInsurancePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/insurance-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeInsurancePolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeInsurancePolicyResponse>(response);
        }

        public AsyncInvoker<RecognizeInsurancePolicyResponse> RecognizeInsurancePolicyAsyncInvoker(RecognizeInsurancePolicyRequest recognizeInsurancePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/insurance-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeInsurancePolicyRequest);
            return new AsyncInvoker<RecognizeInsurancePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeInsurancePolicyResponse>);
        }
        
        /// <summary>
        /// 发票验真
        ///
        /// 发票验真服务支持10种增值税发票的信息核验，包括增值税专用发票、增值税普通发票、增值税普通发票（卷式）、增值税电子专用发票、增值税电子普通发票、增值税电子普通发票（通行费）、二手车销售统一发票、机动车销售统一发票、区块链电子发票、全电发票，支持返回票面的全部信息。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section16)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeInvoiceVerificationResponse> RecognizeInvoiceVerificationAsync(RecognizeInvoiceVerificationRequest recognizeInvoiceVerificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/invoice-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeInvoiceVerificationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeInvoiceVerificationResponse>(response);
        }

        public AsyncInvoker<RecognizeInvoiceVerificationResponse> RecognizeInvoiceVerificationAsyncInvoker(RecognizeInvoiceVerificationRequest recognizeInvoiceVerificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/invoice-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeInvoiceVerificationRequest);
            return new AsyncInvoker<RecognizeInvoiceVerificationResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeInvoiceVerificationResponse>);
        }
        
        /// <summary>
        /// 车牌识别
        ///
        /// 识别输入图片中的车牌信息，并返回其坐标和内容。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section12)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeLicensePlateResponse> RecognizeLicensePlateAsync(RecognizeLicensePlateRequest recognizeLicensePlateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/license-plate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeLicensePlateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeLicensePlateResponse>(response);
        }

        public AsyncInvoker<RecognizeLicensePlateResponse> RecognizeLicensePlateAsyncInvoker(RecognizeLicensePlateRequest recognizeLicensePlateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/license-plate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeLicensePlateRequest);
            return new AsyncInvoker<RecognizeLicensePlateResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeLicensePlateResponse>);
        }
        
        /// <summary>
        /// 澳门身份证识别
        ///
        /// 识别澳门身份证图片中的文字内容，并将识别的结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeMacaoIdCardResponse> RecognizeMacaoIdCardAsync(RecognizeMacaoIdCardRequest recognizeMacaoIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/macao-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMacaoIdCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeMacaoIdCardResponse>(response);
        }

        public AsyncInvoker<RecognizeMacaoIdCardResponse> RecognizeMacaoIdCardAsyncInvoker(RecognizeMacaoIdCardRequest recognizeMacaoIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/macao-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMacaoIdCardRequest);
            return new AsyncInvoker<RecognizeMacaoIdCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeMacaoIdCardResponse>);
        }
        
        /// <summary>
        /// 港澳台居民来往内地通行证识别
        ///
        /// 识别港澳居民来往内地通行证上的文字内容，并将识别的结构化结果返回给用户。支持港澳居民来往内地通行证和台湾居民来往内地通行证两种卡证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeMainlandTravelPermitResponse> RecognizeMainlandTravelPermitAsync(RecognizeMainlandTravelPermitRequest recognizeMainlandTravelPermitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/mainland-travel-permit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMainlandTravelPermitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeMainlandTravelPermitResponse>(response);
        }

        public AsyncInvoker<RecognizeMainlandTravelPermitResponse> RecognizeMainlandTravelPermitAsyncInvoker(RecognizeMainlandTravelPermitRequest recognizeMainlandTravelPermitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/mainland-travel-permit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMainlandTravelPermitRequest);
            return new AsyncInvoker<RecognizeMainlandTravelPermitResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeMainlandTravelPermitResponse>);
        }
        
        /// <summary>
        /// 机动车销售发票识别
        ///
        /// 识别机动车销售发票、二手车销售发票图片（服务能自动分辨两种类型，返回对应的字段）中的文字内容，并将识别的结果以JSON格式返回给用户。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section17)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明：
        /// 该增值税发票仅限于中华人民共和国境内使用的增值税发票。
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeMvsInvoiceResponse> RecognizeMvsInvoiceAsync(RecognizeMvsInvoiceRequest recognizeMvsInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/mvs-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMvsInvoiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeMvsInvoiceResponse>(response);
        }

        public AsyncInvoker<RecognizeMvsInvoiceResponse> RecognizeMvsInvoiceAsyncInvoker(RecognizeMvsInvoiceRequest recognizeMvsInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/mvs-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMvsInvoiceRequest);
            return new AsyncInvoker<RecognizeMvsInvoiceResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeMvsInvoiceResponse>);
        }
        
        /// <summary>
        /// 缅文驾驶证识别
        ///
        /// 识别缅甸驾驶证中的文字信息，并返回识别的结构化结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeMyanmarDriverLicenseResponse> RecognizeMyanmarDriverLicenseAsync(RecognizeMyanmarDriverLicenseRequest recognizeMyanmarDriverLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/myanmar-driver-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMyanmarDriverLicenseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeMyanmarDriverLicenseResponse>(response);
        }

        public AsyncInvoker<RecognizeMyanmarDriverLicenseResponse> RecognizeMyanmarDriverLicenseAsyncInvoker(RecognizeMyanmarDriverLicenseRequest recognizeMyanmarDriverLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/myanmar-driver-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMyanmarDriverLicenseRequest);
            return new AsyncInvoker<RecognizeMyanmarDriverLicenseResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeMyanmarDriverLicenseResponse>);
        }
        
        /// <summary>
        /// 缅文身份证识别
        ///
        /// 识别缅文身份证中的文字信息，并返回识别的结构化结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeMyanmarIdcardResponse> RecognizeMyanmarIdcardAsync(RecognizeMyanmarIdcardRequest recognizeMyanmarIdcardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/myanmar-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMyanmarIdcardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeMyanmarIdcardResponse>(response);
        }

        public AsyncInvoker<RecognizeMyanmarIdcardResponse> RecognizeMyanmarIdcardAsyncInvoker(RecognizeMyanmarIdcardRequest recognizeMyanmarIdcardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/myanmar-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeMyanmarIdcardRequest);
            return new AsyncInvoker<RecognizeMyanmarIdcardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeMyanmarIdcardResponse>);
        }
        
        /// <summary>
        /// 护照识别
        ///
        /// 识别用户上传的护照首页图片中的文字信息，并返回识别的结构化结果。当前版本支持中国护照的全字段识别。外国护照支持护照下方两行国际标准化的机读码识别，并可从中提取6-7个关键字段信息。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section8)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明：
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizePassportResponse> RecognizePassportAsync(RecognizePassportRequest recognizePassportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/passport", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizePassportRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizePassportResponse>(response);
        }

        public AsyncInvoker<RecognizePassportResponse> RecognizePassportAsyncInvoker(RecognizePassportRequest recognizePassportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/passport", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizePassportRequest);
            return new AsyncInvoker<RecognizePassportResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizePassportResponse>);
        }
        
        /// <summary>
        /// 核酸检测记录识别
        ///
        /// 识别核酸检测记录中的文字信息，并将识别的结构化结果返回给用户。PCR，全称Polymerase chain reaction,即聚合酶链式反应。PCR-test也为大众所认知为新型冠状病毒核酸检测测试。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizePcrTestRecordResponse> RecognizePcrTestRecordAsync(RecognizePcrTestRecordRequest recognizePcrTestRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/pcr-test-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizePcrTestRecordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizePcrTestRecordResponse>(response);
        }

        public AsyncInvoker<RecognizePcrTestRecordResponse> RecognizePcrTestRecordAsyncInvoker(RecognizePcrTestRecordRequest recognizePcrTestRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/pcr-test-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizePcrTestRecordRequest);
            return new AsyncInvoker<RecognizePcrTestRecordResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizePcrTestRecordResponse>);
        }
        
        /// <summary>
        /// 秘鲁身份证识别
        ///
        /// 识别秘鲁身份证图片中的文字内容，并将识别的结构化结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizePeruIdCardResponse> RecognizePeruIdCardAsync(RecognizePeruIdCardRequest recognizePeruIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/peru-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizePeruIdCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizePeruIdCardResponse>(response);
        }

        public AsyncInvoker<RecognizePeruIdCardResponse> RecognizePeruIdCardAsyncInvoker(RecognizePeruIdCardRequest recognizePeruIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/peru-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizePeruIdCardRequest);
            return new AsyncInvoker<RecognizePeruIdCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizePeruIdCardResponse>);
        }
        
        /// <summary>
        /// 道路运输从业资格证识别
        ///
        /// 识别道路运输从业资格证上的关键文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section25)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeQualificationCertificateResponse> RecognizeQualificationCertificateAsync(RecognizeQualificationCertificateRequest recognizeQualificationCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/transportation-qualification-certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeQualificationCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeQualificationCertificateResponse>(response);
        }

        public AsyncInvoker<RecognizeQualificationCertificateResponse> RecognizeQualificationCertificateAsyncInvoker(RecognizeQualificationCertificateRequest recognizeQualificationCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/transportation-qualification-certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeQualificationCertificateRequest);
            return new AsyncInvoker<RecognizeQualificationCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeQualificationCertificateResponse>);
        }
        
        /// <summary>
        /// 定额发票识别
        ///
        /// 识别定额发票中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section21)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// 说明： 
        /// 
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceAsync(RecognizeQuotaInvoiceRequest recognizeQuotaInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/quota-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeQuotaInvoiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeQuotaInvoiceResponse>(response);
        }

        public AsyncInvoker<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceAsyncInvoker(RecognizeQuotaInvoiceRequest recognizeQuotaInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/quota-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeQuotaInvoiceRequest);
            return new AsyncInvoker<RecognizeQuotaInvoiceResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeQuotaInvoiceResponse>);
        }
        
        /// <summary>
        /// 不动产证识别
        ///
        /// 识别不动产证中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section11)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明： 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeRealEstateCertificateResponse> RecognizeRealEstateCertificateAsync(RecognizeRealEstateCertificateRequest recognizeRealEstateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/real-estate-certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeRealEstateCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeRealEstateCertificateResponse>(response);
        }

        public AsyncInvoker<RecognizeRealEstateCertificateResponse> RecognizeRealEstateCertificateAsyncInvoker(RecognizeRealEstateCertificateRequest recognizeRealEstateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/real-estate-certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeRealEstateCertificateRequest);
            return new AsyncInvoker<RecognizeRealEstateCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeRealEstateCertificateResponse>);
        }
        
        /// <summary>
        /// 印章识别
        ///
        /// 检测和识别合同文件或常用票据中的印章，并可擦除和提取图片中的印章，通过JSON格式返回印章检测、识别、擦除和提取的结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeSealResponse> RecognizeSealAsync(RecognizeSealRequest recognizeSealRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/seal", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeSealRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeSealResponse>(response);
        }

        public AsyncInvoker<RecognizeSealResponse> RecognizeSealAsyncInvoker(RecognizeSealRequest recognizeSealRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/seal", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeSealRequest);
            return new AsyncInvoker<RecognizeSealResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeSealResponse>);
        }
        
        /// <summary>
        /// 智能文档解析
        ///
        /// 对证件、票据、表单等任意版式文档进行键值对提取、文字识别、以及表格识别等任务，实现进阶高效的自动化结构化返回。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section11)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeSmartDocumentRecognizerResponse> RecognizeSmartDocumentRecognizerAsync(RecognizeSmartDocumentRecognizerRequest recognizeSmartDocumentRecognizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/smart-document-recognizer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeSmartDocumentRecognizerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeSmartDocumentRecognizerResponse>(response);
        }

        public AsyncInvoker<RecognizeSmartDocumentRecognizerResponse> RecognizeSmartDocumentRecognizerAsyncInvoker(RecognizeSmartDocumentRecognizerRequest recognizeSmartDocumentRecognizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/smart-document-recognizer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeSmartDocumentRecognizerRequest);
            return new AsyncInvoker<RecognizeSmartDocumentRecognizerResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeSmartDocumentRecognizerResponse>);
        }
        
        /// <summary>
        /// 出租车发票识别
        ///
        /// 识别出租车发票中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section18)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// 说明：
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceAsync(RecognizeTaxiInvoiceRequest recognizeTaxiInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/taxi-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTaxiInvoiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeTaxiInvoiceResponse>(response);
        }

        public AsyncInvoker<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceAsyncInvoker(RecognizeTaxiInvoiceRequest recognizeTaxiInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/taxi-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTaxiInvoiceRequest);
            return new AsyncInvoker<RecognizeTaxiInvoiceResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeTaxiInvoiceResponse>);
        }
        
        /// <summary>
        /// 泰文身份证识别
        ///
        /// 识别泰国身份证中的文字信息，并返回识别的结构化结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeThailandIdcardResponse> RecognizeThailandIdcardAsync(RecognizeThailandIdcardRequest recognizeThailandIdcardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/thailand-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeThailandIdcardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeThailandIdcardResponse>(response);
        }

        public AsyncInvoker<RecognizeThailandIdcardResponse> RecognizeThailandIdcardAsyncInvoker(RecognizeThailandIdcardRequest recognizeThailandIdcardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/thailand-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeThailandIdcardRequest);
            return new AsyncInvoker<RecognizeThailandIdcardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeThailandIdcardResponse>);
        }
        
        /// <summary>
        /// 泰国车牌识别
        ///
        /// 识别泰国车牌图片中的车牌信息，并返回识别的结构化结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeThailandLicensePlateResponse> RecognizeThailandLicensePlateAsync(RecognizeThailandLicensePlateRequest recognizeThailandLicensePlateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/thailand-license-plate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeThailandLicensePlateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeThailandLicensePlateResponse>(response);
        }

        public AsyncInvoker<RecognizeThailandLicensePlateResponse> RecognizeThailandLicensePlateAsyncInvoker(RecognizeThailandLicensePlateRequest recognizeThailandLicensePlateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/thailand-license-plate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeThailandLicensePlateRequest);
            return new AsyncInvoker<RecognizeThailandLicensePlateResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeThailandLicensePlateResponse>);
        }
        
        /// <summary>
        /// 车辆通行费发票识别
        ///
        /// 识别车辆通行费发票中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section19)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明：
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeTollInvoiceResponse> RecognizeTollInvoiceAsync(RecognizeTollInvoiceRequest recognizeTollInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/toll-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTollInvoiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeTollInvoiceResponse>(response);
        }

        public AsyncInvoker<RecognizeTollInvoiceResponse> RecognizeTollInvoiceAsyncInvoker(RecognizeTollInvoiceRequest recognizeTollInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/toll-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTollInvoiceRequest);
            return new AsyncInvoker<RecognizeTollInvoiceResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeTollInvoiceResponse>);
        }
        
        /// <summary>
        /// 火车票识别
        ///
        /// 识别火车票中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section22)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明：
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeTrainTicketResponse> RecognizeTrainTicketAsync(RecognizeTrainTicketRequest recognizeTrainTicketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/train-ticket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTrainTicketRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeTrainTicketResponse>(response);
        }

        public AsyncInvoker<RecognizeTrainTicketResponse> RecognizeTrainTicketAsyncInvoker(RecognizeTrainTicketRequest recognizeTrainTicketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/train-ticket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTrainTicketRequest);
            return new AsyncInvoker<RecognizeTrainTicketResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeTrainTicketResponse>);
        }
        
        /// <summary>
        /// 道路运输证识别
        ///
        /// 识别道路运输证首页中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section11)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明： 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeTransportationLicenseResponse> RecognizeTransportationLicenseAsync(RecognizeTransportationLicenseRequest recognizeTransportationLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/transportation-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTransportationLicenseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeTransportationLicenseResponse>(response);
        }

        public AsyncInvoker<RecognizeTransportationLicenseResponse> RecognizeTransportationLicenseAsyncInvoker(RecognizeTransportationLicenseRequest recognizeTransportationLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/transportation-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeTransportationLicenseRequest);
            return new AsyncInvoker<RecognizeTransportationLicenseResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeTransportationLicenseResponse>);
        }
        
        /// <summary>
        /// 增值税发票识别
        ///
        /// 识别增值税发票的类别，以及图片中的文字内容，并以json格式返回识别的结构化结果，不支持真伪验证。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section15)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明：
        /// 该增值税发票仅限于中华人民共和国境内使用的增值税发票。
        /// 支持的增值税发票包括：增值税专用发票、增值税普通发票、增值税电子普通发票、增值税电子专用发票、增值税电子普通发票（通行费）、增值税普通发票（卷票）。
        /// 如果图片中包含多张卡证票据，请调用智能分类识别服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeVatInvoiceResponse> RecognizeVatInvoiceAsync(RecognizeVatInvoiceRequest recognizeVatInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vat-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVatInvoiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeVatInvoiceResponse>(response);
        }

        public AsyncInvoker<RecognizeVatInvoiceResponse> RecognizeVatInvoiceAsyncInvoker(RecognizeVatInvoiceRequest recognizeVatInvoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vat-invoice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVatInvoiceRequest);
            return new AsyncInvoker<RecognizeVatInvoiceResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeVatInvoiceResponse>);
        }
        
        /// <summary>
        /// 车辆合格证识别
        ///
        /// 识别车辆合格证中的文字信息，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section11)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeVehicleCertificateResponse> RecognizeVehicleCertificateAsync(RecognizeVehicleCertificateRequest recognizeVehicleCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vehicle-certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVehicleCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeVehicleCertificateResponse>(response);
        }

        public AsyncInvoker<RecognizeVehicleCertificateResponse> RecognizeVehicleCertificateAsyncInvoker(RecognizeVehicleCertificateRequest recognizeVehicleCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vehicle-certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVehicleCertificateRequest);
            return new AsyncInvoker<RecognizeVehicleCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeVehicleCertificateResponse>);
        }
        
        /// <summary>
        /// 行驶证识别
        ///
        /// 识别用户上传的行驶证图片（或者用户提供的华为云上OBS的行驶证图片文件的URL）中主页和副页的文字内容，并将识别的结果返回给用户。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section7)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 说明：
        /// 如果图片中包含多张卡证票据，请调用[智能分类识别](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;OCR&amp;api&#x3D;AutoClassification)服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseAsync(RecognizeVehicleLicenseRequest recognizeVehicleLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vehicle-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVehicleLicenseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeVehicleLicenseResponse>(response);
        }

        public AsyncInvoker<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseAsyncInvoker(RecognizeVehicleLicenseRequest recognizeVehicleLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vehicle-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVehicleLicenseRequest);
            return new AsyncInvoker<RecognizeVehicleLicenseResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeVehicleLicenseResponse>);
        }
        
        /// <summary>
        /// 越南身份证识别
        ///
        /// 识别越南身份证中的文字信息，并将识别的结构化结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeVietnamIdCardResponse> RecognizeVietnamIdCardAsync(RecognizeVietnamIdCardRequest recognizeVietnamIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vietnam-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVietnamIdCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeVietnamIdCardResponse>(response);
        }

        public AsyncInvoker<RecognizeVietnamIdCardResponse> RecognizeVietnamIdCardAsyncInvoker(RecognizeVietnamIdCardRequest recognizeVietnamIdCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vietnam-id-card", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVietnamIdCardRequest);
            return new AsyncInvoker<RecognizeVietnamIdCardResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeVietnamIdCardResponse>);
        }
        
        /// <summary>
        /// 电子面单识别
        ///
        /// 识别用户上传的电子面单图片中的文字内容，并将识别的结果以json格式返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeWaybillElectronicResponse> RecognizeWaybillElectronicAsync(RecognizeWaybillElectronicRequest recognizeWaybillElectronicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/waybill-electronic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeWaybillElectronicRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeWaybillElectronicResponse>(response);
        }

        public AsyncInvoker<RecognizeWaybillElectronicResponse> RecognizeWaybillElectronicAsyncInvoker(RecognizeWaybillElectronicRequest recognizeWaybillElectronicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/waybill-electronic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeWaybillElectronicRequest);
            return new AsyncInvoker<RecognizeWaybillElectronicResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeWaybillElectronicResponse>);
        }
        
        /// <summary>
        /// 网络图片识别
        ///
        /// 识别网络图片中的文字内容，并返回识别的结构化结果。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section2)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeWebImageResponse> RecognizeWebImageAsync(RecognizeWebImageRequest recognizeWebImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/web-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeWebImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeWebImageResponse>(response);
        }

        public AsyncInvoker<RecognizeWebImageResponse> RecognizeWebImageAsyncInvoker(RecognizeWebImageRequest recognizeWebImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/web-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeWebImageRequest);
            return new AsyncInvoker<RecognizeWebImageResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeWebImageResponse>);
        }
        
        /// <summary>
        /// 自定义模板OCR
        ///
        /// 自定义模板OCR，支持用户自定义模板，对于版式固定的各种票据和卡证，通过可视化界面操作，指定需要识别的关键字段，实现用户特定格式图片的自动识别和结构化提取。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeCustomTemplateResponse> RecognizeCustomTemplateAsync(RecognizeCustomTemplateRequest recognizeCustomTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/custom-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeCustomTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeCustomTemplateResponse>(response);
        }

        public AsyncInvoker<RecognizeCustomTemplateResponse> RecognizeCustomTemplateAsyncInvoker(RecognizeCustomTemplateRequest recognizeCustomTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/custom-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeCustomTemplateRequest);
            return new AsyncInvoker<RecognizeCustomTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeCustomTemplateResponse>);
        }
        
        /// <summary>
        /// VIN码识别
        ///
        /// 识别图片中的车架号信息，并将识别结果返回给用户。该接口的使用限制请参见[约束与限制](https://support.huaweicloud.com/productdesc-ocr/ocr_01_0006.html#section14)，详细使用指导请参见[OCR服务使用简介](https://support.huaweicloud.com/qs-ocr/ocr_05_0001.html)章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeVinResponse> RecognizeVinAsync(RecognizeVinRequest recognizeVinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVinRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeVinResponse>(response);
        }

        public AsyncInvoker<RecognizeVinResponse> RecognizeVinAsyncInvoker(RecognizeVinRequest recognizeVinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ocr/vin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeVinRequest);
            return new AsyncInvoker<RecognizeVinResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeVinResponse>);
        }
        
    }
}
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kms.V2.Model;

namespace HuaweiCloud.SDK.Kms.V2
{
    public partial class KmsAsyncClient : Client
    {
        public static ClientBuilder<KmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<KmsAsyncClient>();
        }

        
        /// <summary>
        /// 
        ///
        /// 关联别名。
        /// 你可以将别名从原密钥关联到另一个新的密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateAliasResponse> AssociateAliasAsync(AssociateAliasRequest associateAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/alias/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAliasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateAliasResponse>(response);
        }

        public AsyncInvoker<AssociateAliasResponse> AssociateAliasAsyncInvoker(AssociateAliasRequest associateAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/alias/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAliasRequest);
            return new AsyncInvoker<AssociateAliasResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateAliasResponse>);
        }
        
        /// <summary>
        /// 批量添加删除密钥标签
        ///
        /// - 功能介绍：批量添加删除密钥标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateKmsTagsResponse> BatchCreateKmsTagsAsync(BatchCreateKmsTagsRequest batchCreateKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", batchCreateKmsTagsRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateKmsTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateKmsTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateKmsTagsResponse> BatchCreateKmsTagsAsyncInvoker(BatchCreateKmsTagsRequest batchCreateKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", batchCreateKmsTagsRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateKmsTagsRequest);
            return new AsyncInvoker<BatchCreateKmsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateKmsTagsResponse>);
        }
        
        /// <summary>
        /// 撤销授权
        ///
        /// - 功能介绍：撤销授权，授权用户撤销被授权用户操作密钥的权限。
        /// - 说明：
        ///    - 创建密钥的用户才能撤销该密钥授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelGrantResponse> CancelGrantAsync(CancelGrantRequest cancelGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/revoke-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CancelGrantResponse>(response);
        }

        public AsyncInvoker<CancelGrantResponse> CancelGrantAsyncInvoker(CancelGrantRequest cancelGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/revoke-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            return new AsyncInvoker<CancelGrantResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CancelGrantResponse>);
        }
        
        /// <summary>
        /// 取消计划删除密钥
        ///
        /// - 功能介绍：取消计划删除密钥。
        /// - 说明：密钥处于“计划删除”状态才能取消计划删除密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest cancelKeyDeletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/cancel-key-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelKeyDeletionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CancelKeyDeletionResponse>(response);
        }

        public AsyncInvoker<CancelKeyDeletionResponse> CancelKeyDeletionAsyncInvoker(CancelKeyDeletionRequest cancelKeyDeletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/cancel-key-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelKeyDeletionRequest);
            return new AsyncInvoker<CancelKeyDeletionResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelKeyDeletionResponse>);
        }
        
        /// <summary>
        /// 退役授权
        ///
        /// - 功能介绍：退役授权，表示被授权用户不再具有授权密钥的操作权。
        ///   例如：用户A授权用户B可以操作密钥A/key，同时授权用户C可以撤销该授权，
        ///   那么用户A、B、C均可退役该授权，退役授权后，用户B不再可以使用A/key。
        /// - 须知：
        ///      可执行退役授权的主体包括：
        ///    - 创建授权的用户；
        ///    - 授权中retiring_principal指向的用户；
        ///    - 当授权的操作列表中包含retire-grant时，grantee_principal指向的用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelSelfGrantResponse> CancelSelfGrantAsync(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/retire-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CancelSelfGrantResponse>(response);
        }

        public AsyncInvoker<CancelSelfGrantResponse> CancelSelfGrantAsyncInvoker(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/retire-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            return new AsyncInvoker<CancelSelfGrantResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CancelSelfGrantResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest createAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAliasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAliasResponse>(response);
        }

        public AsyncInvoker<CreateAliasResponse> CreateAliasAsyncInvoker(CreateAliasRequest createAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAliasRequest);
            return new AsyncInvoker<CreateAliasResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAliasResponse>);
        }
        
        /// <summary>
        /// 创建数据密钥
        ///
        /// - 功能介绍：创建数据密钥，返回结果包含明文和密文。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatakeyResponse> CreateDatakeyAsync(CreateDatakeyRequest createDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDatakeyResponse>(response);
        }

        public AsyncInvoker<CreateDatakeyResponse> CreateDatakeyAsyncInvoker(CreateDatakeyRequest createDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            return new AsyncInvoker<CreateDatakeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatakeyResponse>);
        }
        
        /// <summary>
        /// 创建不含明文数据密钥
        ///
        /// - 功能介绍：创建数据密钥，返回结果只包含密文。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatakeyWithoutPlaintextResponse> CreateDatakeyWithoutPlaintextAsync(CreateDatakeyWithoutPlaintextRequest createDatakeyWithoutPlaintextRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey-without-plaintext", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyWithoutPlaintextRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDatakeyWithoutPlaintextResponse>(response);
        }

        public AsyncInvoker<CreateDatakeyWithoutPlaintextResponse> CreateDatakeyWithoutPlaintextAsyncInvoker(CreateDatakeyWithoutPlaintextRequest createDatakeyWithoutPlaintextRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey-without-plaintext", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyWithoutPlaintextRequest);
            return new AsyncInvoker<CreateDatakeyWithoutPlaintextResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatakeyWithoutPlaintextResponse>);
        }
        
        /// <summary>
        /// 创建EC数据密钥对
        ///
        /// - 功能介绍：创建EC数据密钥对，返回结果包含明文公钥和密文私钥，根据参数决定是否返回明文私钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEcDatakeyPairResponse> CreateEcDatakeyPairAsync(CreateEcDatakeyPairRequest createEcDatakeyPairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-ec-datakey-pair", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEcDatakeyPairRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEcDatakeyPairResponse>(response);
        }

        public AsyncInvoker<CreateEcDatakeyPairResponse> CreateEcDatakeyPairAsyncInvoker(CreateEcDatakeyPairRequest createEcDatakeyPairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-ec-datakey-pair", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEcDatakeyPairRequest);
            return new AsyncInvoker<CreateEcDatakeyPairResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEcDatakeyPairResponse>);
        }
        
        /// <summary>
        /// 创建授权
        ///
        /// - 功能介绍：创建授权，被授权用户可以对授权密钥进行操作。
        /// - 说明：
        ///    - 服务默认主密钥（密钥别名后缀为“/default”）不可以授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest createGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGrantResponse>(response);
        }

        public AsyncInvoker<CreateGrantResponse> CreateGrantAsyncInvoker(CreateGrantRequest createGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            return new AsyncInvoker<CreateGrantResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGrantResponse>);
        }
        
        /// <summary>
        /// 创建密钥
        ///
        /// 创建用户主密钥，用户主密钥可以为对称密钥或非对称密钥。
        /// - 对称密钥为长度为256位AES密钥或者128位SM4密钥，可用于小量数据的加密或者用于加密数据密钥。
        /// - 非对称密钥可以为RSA密钥对或者ECC密钥对（包含SM2密钥对），可用于加解密数据、数字签名及验签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest createKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKeyResponse>(response);
        }

        public AsyncInvoker<CreateKeyResponse> CreateKeyAsyncInvoker(CreateKeyRequest createKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            return new AsyncInvoker<CreateKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKeyResponse>);
        }
        
        /// <summary>
        /// 创建专属密钥库
        ///
        /// - \&quot;创建租户专属密钥库，专属密钥库使用DHSM实例作为密钥的存储\&quot;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKeyStoreResponse> CreateKeyStoreAsync(CreateKeyStoreRequest createKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyStoreRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKeyStoreResponse>(response);
        }

        public AsyncInvoker<CreateKeyStoreResponse> CreateKeyStoreAsyncInvoker(CreateKeyStoreRequest createKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyStoreRequest);
            return new AsyncInvoker<CreateKeyStoreResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKeyStoreResponse>);
        }
        
        /// <summary>
        /// 添加密钥标签
        ///
        /// - 功能介绍：添加密钥标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKmsTagResponse> CreateKmsTagAsync(CreateKmsTagRequest createKmsTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", createKmsTagRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKmsTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateKmsTagResponse>(response);
        }

        public AsyncInvoker<CreateKmsTagResponse> CreateKmsTagAsyncInvoker(CreateKmsTagRequest createKmsTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", createKmsTagRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKmsTagRequest);
            return new AsyncInvoker<CreateKmsTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateKmsTagResponse>);
        }
        
        /// <summary>
        /// 获取密钥导入参数
        ///
        /// - 功能介绍：获取导入密钥的必要参数，包括密钥导入令牌和密钥加密公钥。
        /// - 说明：返回的公钥类型默认为RSA_2048。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateParametersForImportResponse> CreateParametersForImportAsync(CreateParametersForImportRequest createParametersForImportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-parameters-for-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createParametersForImportRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateParametersForImportResponse>(response);
        }

        public AsyncInvoker<CreateParametersForImportResponse> CreateParametersForImportAsyncInvoker(CreateParametersForImportRequest createParametersForImportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-parameters-for-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createParametersForImportRequest);
            return new AsyncInvoker<CreateParametersForImportResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateParametersForImportResponse>);
        }
        
        /// <summary>
        /// 创建PIN码
        ///
        /// - 功能介绍：创建pin码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePinResponse> CreatePinAsync(CreatePinRequest createPinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-pin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPinRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePinResponse>(response);
        }

        public AsyncInvoker<CreatePinResponse> CreatePinAsyncInvoker(CreatePinRequest createPinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-pin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPinRequest);
            return new AsyncInvoker<CreatePinResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePinResponse>);
        }
        
        /// <summary>
        /// 创建随机数
        ///
        /// - 功能介绍：
        ///   生成8~8192bit范围内的随机数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRandomResponse> CreateRandomAsync(CreateRandomRequest createRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/gen-random", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRandomResponse>(response);
        }

        public AsyncInvoker<CreateRandomResponse> CreateRandomAsyncInvoker(CreateRandomRequest createRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/gen-random", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            return new AsyncInvoker<CreateRandomResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRandomResponse>);
        }
        
        /// <summary>
        /// 创建RSA数据密钥对
        ///
        /// - 功能介绍：创建rsa数据密钥对，返回结果包含明文公钥和密文私钥，根据参数决定是否返回明文私钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRsaDatakeyPairResponse> CreateRsaDatakeyPairAsync(CreateRsaDatakeyPairRequest createRsaDatakeyPairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-rsa-datakey-pair", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRsaDatakeyPairRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRsaDatakeyPairResponse>(response);
        }

        public AsyncInvoker<CreateRsaDatakeyPairResponse> CreateRsaDatakeyPairAsyncInvoker(CreateRsaDatakeyPairRequest createRsaDatakeyPairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-rsa-datakey-pair", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRsaDatakeyPairRequest);
            return new AsyncInvoker<CreateRsaDatakeyPairResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRsaDatakeyPairResponse>);
        }
        
        /// <summary>
        /// 解密数据
        ///
        /// - 功能介绍：解密数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DecryptDataResponse> DecryptDataAsync(DecryptDataRequest decryptDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DecryptDataResponse>(response);
        }

        public AsyncInvoker<DecryptDataResponse> DecryptDataAsyncInvoker(DecryptDataRequest decryptDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            return new AsyncInvoker<DecryptDataResponse>(this, "POST", request, JsonUtils.DeSerialize<DecryptDataResponse>);
        }
        
        /// <summary>
        /// 解密数据密钥
        ///
        /// - 功能介绍：解密数据密钥，用指定的主密钥解密数据密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DecryptDatakeyResponse> DecryptDatakeyAsync(DecryptDatakeyRequest decryptDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DecryptDatakeyResponse>(response);
        }

        public AsyncInvoker<DecryptDatakeyResponse> DecryptDatakeyAsyncInvoker(DecryptDatakeyRequest decryptDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            return new AsyncInvoker<DecryptDatakeyResponse>(this, "POST", request, JsonUtils.DeSerialize<DecryptDatakeyResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 删除别名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest deleteAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAliasRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAliasResponse>(response);
        }

        public AsyncInvoker<DeleteAliasResponse> DeleteAliasAsyncInvoker(DeleteAliasRequest deleteAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAliasRequest);
            return new AsyncInvoker<DeleteAliasResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAliasResponse>);
        }
        
        /// <summary>
        /// 删除密钥材料
        ///
        /// - 功能介绍：删除密钥材料信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest deleteImportedKeyMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/delete-imported-key-material", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>(response);
        }

        public AsyncInvoker<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsyncInvoker(DeleteImportedKeyMaterialRequest deleteImportedKeyMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/delete-imported-key-material", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            return new AsyncInvoker<DeleteImportedKeyMaterialResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>);
        }
        
        /// <summary>
        /// 计划删除密钥
        ///
        /// - 功能介绍：计划多少天后删除密钥，可设置7天～1096天内删除密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest deleteKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/schedule-key-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteKeyResponse>(response);
        }

        public AsyncInvoker<DeleteKeyResponse> DeleteKeyAsyncInvoker(DeleteKeyRequest deleteKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/schedule-key-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            return new AsyncInvoker<DeleteKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteKeyResponse>);
        }
        
        /// <summary>
        /// 删除专属密钥库
        ///
        /// 删除租户专属密钥库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKeyStoreResponse> DeleteKeyStoreAsync(DeleteKeyStoreRequest deleteKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", deleteKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeyStoreRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteKeyStoreResponse>(response);
        }

        public AsyncInvoker<DeleteKeyStoreResponse> DeleteKeyStoreAsyncInvoker(DeleteKeyStoreRequest deleteKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", deleteKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeyStoreRequest);
            return new AsyncInvoker<DeleteKeyStoreResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteKeyStoreResponse>);
        }
        
        /// <summary>
        /// 删除密钥标签
        ///
        /// - 功能介绍：删除密钥标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", deleteTagRequest.KeyId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public AsyncInvoker<DeleteTagResponse> DeleteTagAsyncInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", deleteTagRequest.KeyId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new AsyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 禁用密钥
        ///
        /// - 功能介绍：禁用密钥，密钥禁用后不可以使用。
        /// - 说明：密钥为启用状态才能禁用密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest disableKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisableKeyResponse>(response);
        }

        public AsyncInvoker<DisableKeyResponse> DisableKeyAsyncInvoker(DisableKeyRequest disableKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            return new AsyncInvoker<DisableKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableKeyResponse>);
        }
        
        /// <summary>
        /// 关闭密钥轮换
        ///
        /// - 功能介绍：关闭用户主密钥轮换。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest disableKeyRotationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key-rotation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableKeyRotationResponse>(response);
        }

        public AsyncInvoker<DisableKeyRotationResponse> DisableKeyRotationAsyncInvoker(DisableKeyRotationRequest disableKeyRotationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key-rotation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            return new AsyncInvoker<DisableKeyRotationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableKeyRotationResponse>);
        }
        
        /// <summary>
        /// 禁用专属密钥库
        ///
        /// 禁用租户专属密钥库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableKeyStoreResponse> DisableKeyStoreAsync(DisableKeyStoreRequest disableKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", disableKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableKeyStoreRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisableKeyStoreResponse>(response);
        }

        public AsyncInvoker<DisableKeyStoreResponse> DisableKeyStoreAsyncInvoker(DisableKeyStoreRequest disableKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", disableKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableKeyStoreRequest);
            return new AsyncInvoker<DisableKeyStoreResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableKeyStoreResponse>);
        }
        
        /// <summary>
        /// 启用密钥
        ///
        /// - 功能介绍：启用密钥，密钥启用后才可以使用。
        /// - 说明：密钥为禁用状态才能启用密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest enableKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableKeyResponse>(response);
        }

        public AsyncInvoker<EnableKeyResponse> EnableKeyAsyncInvoker(EnableKeyRequest enableKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            return new AsyncInvoker<EnableKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableKeyResponse>);
        }
        
        /// <summary>
        /// 开启密钥轮换
        ///
        /// - 功能介绍：开启用户主密钥轮换。
        /// - 说明：
        ///   - 开启密钥轮换后，默认轮换间隔时间为365天。
        ///   - 默认主密钥及外部导入密钥不支持轮换操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest enableKeyRotationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key-rotation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableKeyRotationResponse>(response);
        }

        public AsyncInvoker<EnableKeyRotationResponse> EnableKeyRotationAsyncInvoker(EnableKeyRotationRequest enableKeyRotationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key-rotation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            return new AsyncInvoker<EnableKeyRotationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableKeyRotationResponse>);
        }
        
        /// <summary>
        /// 启用专属密钥库
        ///
        /// 启用租户专属密钥库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableKeyStoreResponse> EnableKeyStoreAsync(EnableKeyStoreRequest enableKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", enableKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableKeyStoreRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableKeyStoreResponse>(response);
        }

        public AsyncInvoker<EnableKeyStoreResponse> EnableKeyStoreAsyncInvoker(EnableKeyStoreRequest enableKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", enableKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableKeyStoreRequest);
            return new AsyncInvoker<EnableKeyStoreResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableKeyStoreResponse>);
        }
        
        /// <summary>
        /// 加密数据
        ///
        /// - 功能介绍：加密数据，用指定的用户主密钥加密数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EncryptDataResponse> EncryptDataAsync(EncryptDataRequest encryptDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EncryptDataResponse>(response);
        }

        public AsyncInvoker<EncryptDataResponse> EncryptDataAsyncInvoker(EncryptDataRequest encryptDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            return new AsyncInvoker<EncryptDataResponse>(this, "POST", request, JsonUtils.DeSerialize<EncryptDataResponse>);
        }
        
        /// <summary>
        /// 加密数据密钥
        ///
        /// - 功能介绍：加密数据密钥，用指定的主密钥加密数据密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EncryptDatakeyResponse> EncryptDatakeyAsync(EncryptDatakeyRequest encryptDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EncryptDatakeyResponse>(response);
        }

        public AsyncInvoker<EncryptDatakeyResponse> EncryptDatakeyAsyncInvoker(EncryptDatakeyRequest encryptDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            return new AsyncInvoker<EncryptDatakeyResponse>(this, "POST", request, JsonUtils.DeSerialize<EncryptDatakeyResponse>);
        }
        
        /// <summary>
        /// 生成消息验证码
        ///
        /// 功能介绍：生成消息验证码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GenerateMacResponse> GenerateMacAsync(GenerateMacRequest generateMacRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/generate-mac", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateMacRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GenerateMacResponse>(response);
        }

        public AsyncInvoker<GenerateMacResponse> GenerateMacAsyncInvoker(GenerateMacRequest generateMacRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/generate-mac", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateMacRequest);
            return new AsyncInvoker<GenerateMacResponse>(this, "POST", request, JsonUtils.DeSerialize<GenerateMacResponse>);
        }
        
        /// <summary>
        /// 导入密钥材料
        ///
        /// - 功能介绍：导入密钥材料。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest importKeyMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/import-key-material", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>(response);
        }

        public AsyncInvoker<ImportKeyMaterialResponse> ImportKeyMaterialAsyncInvoker(ImportKeyMaterialRequest importKeyMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/import-key-material", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            return new AsyncInvoker<ImportKeyMaterialResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询一个密钥关联的所有别名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest listAliasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAliasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listAliasesResponse = JsonUtils.DeSerializeNull<ListAliasesResponse>(response);
            listAliasesResponse.Body = JsonUtils.DeSerializeList<ListAliasResponseBody>(response);
            return listAliasesResponse;
        }

        public AsyncInvoker<ListAliasesResponse> ListAliasesAsyncInvoker(ListAliasesRequest listAliasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAliasesRequest);
            return new AsyncInvoker<ListAliasesResponse>(this, "GET", request, response =>
            {
                var listAliasesResponse = JsonUtils.DeSerializeNull<ListAliasesResponse>(response);
                listAliasesResponse.Body = JsonUtils.DeSerializeList<ListAliasResponseBody>(response);
                return listAliasesResponse;
            });
        }
        
        /// <summary>
        /// 查询授权列表
        ///
        /// - 功能介绍：查询密钥的授权列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest listGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
        }

        public AsyncInvoker<ListGrantsResponse> ListGrantsAsyncInvoker(ListGrantsRequest listGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            return new AsyncInvoker<ListGrantsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGrantsResponse>);
        }
        
        /// <summary>
        /// 查询密钥信息
        ///
        /// - 功能介绍：查询密钥详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKeyDetailResponse> ListKeyDetailAsync(ListKeyDetailRequest listKeyDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/describe-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListKeyDetailResponse>(response);
        }

        public AsyncInvoker<ListKeyDetailResponse> ListKeyDetailAsyncInvoker(ListKeyDetailRequest listKeyDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/describe-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            return new AsyncInvoker<ListKeyDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ListKeyDetailResponse>);
        }
        
        /// <summary>
        /// 查询专属密钥库列表
        ///
        /// 查询租户专属密钥库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKeyStoresResponse> ListKeyStoresAsync(ListKeyStoresRequest listKeyStoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyStoresRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListKeyStoresResponse>(response);
        }

        public AsyncInvoker<ListKeyStoresResponse> ListKeyStoresAsyncInvoker(ListKeyStoresRequest listKeyStoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyStoresRequest);
            return new AsyncInvoker<ListKeyStoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeyStoresResponse>);
        }
        
        /// <summary>
        /// 查询密钥列表
        ///
        /// - 功能介绍：查询用户所有密钥列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKeysResponse> ListKeysAsync(ListKeysRequest listKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListKeysResponse>(response);
        }

        public AsyncInvoker<ListKeysResponse> ListKeysAsyncInvoker(ListKeysRequest listKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            return new AsyncInvoker<ListKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<ListKeysResponse>);
        }
        
        /// <summary>
        /// 查询密钥实例
        ///
        /// - 功能介绍：查询密钥实例。通过标签过滤，查询指定用户主密钥的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKmsByTagsResponse> ListKmsByTagsAsync(ListKmsByTagsRequest listKmsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances", listKmsByTagsRequest.ResourceInstances.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{resource_instances}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListKmsByTagsResponse>(response);
        }

        public AsyncInvoker<ListKmsByTagsResponse> ListKmsByTagsAsyncInvoker(ListKmsByTagsRequest listKmsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances", listKmsByTagsRequest.ResourceInstances.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{resource_instances}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            return new AsyncInvoker<ListKmsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListKmsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// - 功能介绍：查询用户在指定项目下的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKmsTagsResponse> ListKmsTagsAsync(ListKmsTagsRequest listKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListKmsTagsResponse>(response);
        }

        public AsyncInvoker<ListKmsTagsResponse> ListKmsTagsAsyncInvoker(ListKmsTagsRequest listKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            return new AsyncInvoker<ListKmsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKmsTagsResponse>);
        }
        
        /// <summary>
        /// 查询可退役授权列表
        ///
        /// - 功能介绍：查询用户可以退役的授权列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest listRetirableGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-retirable-grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListRetirableGrantsResponse>(response);
        }

        public AsyncInvoker<ListRetirableGrantsResponse> ListRetirableGrantsAsyncInvoker(ListRetirableGrantsRequest listRetirableGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-retirable-grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            return new AsyncInvoker<ListRetirableGrantsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRetirableGrantsResponse>);
        }
        
        /// <summary>
        /// 查询跨区域密钥所支持的区域
        ///
        /// - 功能介绍：查询跨区域密钥所支持的区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSupportRegionsResponse> ListSupportRegionsAsync(ListSupportRegionsRequest listSupportRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSupportRegionsResponse>(response);
        }

        public AsyncInvoker<ListSupportRegionsResponse> ListSupportRegionsAsyncInvoker(ListSupportRegionsRequest listSupportRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportRegionsRequest);
            return new AsyncInvoker<ListSupportRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportRegionsResponse>);
        }
        
        /// <summary>
        /// 复制密钥到指定区域
        ///
        /// 将本区域的密钥复制到指定区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReplicateKeyResponse> ReplicateKeyAsync(ReplicateKeyRequest replicateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", replicateKeyRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/keys/{key_id}/replicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", replicateKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReplicateKeyResponse>(response);
        }

        public AsyncInvoker<ReplicateKeyResponse> ReplicateKeyAsyncInvoker(ReplicateKeyRequest replicateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", replicateKeyRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/keys/{key_id}/replicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", replicateKeyRequest);
            return new AsyncInvoker<ReplicateKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ReplicateKeyResponse>);
        }
        
        /// <summary>
        /// 查询密钥轮换状态
        ///
        /// - 功能介绍：查询用户主密钥轮换状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKeyRotationStatusResponse> ShowKeyRotationStatusAsync(ShowKeyRotationStatusRequest showKeyRotationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-key-rotation-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>(response);
        }

        public AsyncInvoker<ShowKeyRotationStatusResponse> ShowKeyRotationStatusAsyncInvoker(ShowKeyRotationStatusRequest showKeyRotationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-key-rotation-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            return new AsyncInvoker<ShowKeyRotationStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>);
        }
        
        /// <summary>
        /// 获取专属密钥库
        ///
        /// 获取租户专属密钥库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKeyStoreResponse> ShowKeyStoreAsync(ShowKeyStoreRequest showKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", showKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeyStoreRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKeyStoreResponse>(response);
        }

        public AsyncInvoker<ShowKeyStoreResponse> ShowKeyStoreAsyncInvoker(ShowKeyStoreRequest showKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", showKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeyStoreRequest);
            return new AsyncInvoker<ShowKeyStoreResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKeyStoreResponse>);
        }
        
        /// <summary>
        /// 查询密钥标签
        ///
        /// - 功能介绍：查询密钥标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKmsTagsResponse> ShowKmsTagsAsync(ShowKmsTagsRequest showKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", showKmsTagsRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKmsTagsResponse>(response);
        }

        public AsyncInvoker<ShowKmsTagsResponse> ShowKmsTagsAsyncInvoker(ShowKmsTagsRequest showKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", showKmsTagsRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            return new AsyncInvoker<ShowKmsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKmsTagsResponse>);
        }
        
        /// <summary>
        /// 查询公钥信息
        ///
        /// - 查询用户指定非对称密钥的公钥信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicKeyResponse> ShowPublicKeyAsync(ShowPublicKeyRequest showPublicKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-publickey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublicKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowPublicKeyResponse>(response);
        }

        public AsyncInvoker<ShowPublicKeyResponse> ShowPublicKeyAsyncInvoker(ShowPublicKeyRequest showPublicKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-publickey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublicKeyRequest);
            return new AsyncInvoker<ShowPublicKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowPublicKeyResponse>);
        }
        
        /// <summary>
        /// 查询实例数
        ///
        /// - 功能介绍：查询实例数，获取用户已经创建的用户主密钥数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserInstancesResponse> ShowUserInstancesAsync(ShowUserInstancesRequest showUserInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserInstancesResponse>(response);
        }

        public AsyncInvoker<ShowUserInstancesResponse> ShowUserInstancesAsyncInvoker(ShowUserInstancesRequest showUserInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            return new AsyncInvoker<ShowUserInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserInstancesResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// - 功能介绍：查询配额，查询用户可以创建的用户主密钥配额总数及当前使用量信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserQuotasResponse> ShowUserQuotasAsync(ShowUserQuotasRequest showUserQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserQuotasResponse>(response);
        }

        public AsyncInvoker<ShowUserQuotasResponse> ShowUserQuotasAsyncInvoker(ShowUserQuotasRequest showUserQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            return new AsyncInvoker<ShowUserQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserQuotasResponse>);
        }
        
        /// <summary>
        /// 签名数据
        ///
        /// - 功能介绍：使用非对称密钥的私钥对消息或消息摘要进行数字签名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SignResponse> SignAsync(SignRequest signRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/sign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", signRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SignResponse>(response);
        }

        public AsyncInvoker<SignResponse> SignAsyncInvoker(SignRequest signRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/sign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", signRequest);
            return new AsyncInvoker<SignResponse>(this, "POST", request, JsonUtils.DeSerialize<SignResponse>);
        }
        
        /// <summary>
        /// 修改密钥别名
        ///
        /// - 功能介绍：修改用户主密钥别名。
        /// - 说明：
        ///    - 服务默认主密钥（密钥别名后缀为“/default”）不可以修改。
        ///    - 密钥处于“计划删除”状态，密钥别名不可以修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKeyAliasResponse> UpdateKeyAliasAsync(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyAliasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateKeyAliasResponse>(response);
        }

        public AsyncInvoker<UpdateKeyAliasResponse> UpdateKeyAliasAsyncInvoker(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyAliasRequest);
            return new AsyncInvoker<UpdateKeyAliasResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateKeyAliasResponse>);
        }
        
        /// <summary>
        /// 修改密钥描述
        ///
        /// - 功能介绍：修改用户主密钥描述信息。
        /// - 说明：
        ///    - 服务默认主密钥（密钥别名后缀为“/default”）不可以修改。
        ///    - 密钥处于“计划删除”状态，密钥描述不可以修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>(response);
        }

        public AsyncInvoker<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsyncInvoker(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            return new AsyncInvoker<UpdateKeyDescriptionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>);
        }
        
        /// <summary>
        /// 修改密钥轮换周期
        ///
        /// - 功能介绍：修改用户主密钥轮换周期。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKeyRotationIntervalResponse> UpdateKeyRotationIntervalAsync(UpdateKeyRotationIntervalRequest updateKeyRotationIntervalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-rotation-interval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>(response);
        }

        public AsyncInvoker<UpdateKeyRotationIntervalResponse> UpdateKeyRotationIntervalAsyncInvoker(UpdateKeyRotationIntervalRequest updateKeyRotationIntervalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-rotation-interval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            return new AsyncInvoker<UpdateKeyRotationIntervalResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>);
        }
        
        /// <summary>
        /// 修改密钥所属的主区域
        ///
        /// 修改密钥所属的主区域。修改后当前区域会变为副本区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrimaryRegionResponse> UpdatePrimaryRegionAsync(UpdatePrimaryRegionRequest updatePrimaryRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", updatePrimaryRegionRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/keys/{key_id}/update-primary-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrimaryRegionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrimaryRegionResponse>(response);
        }

        public AsyncInvoker<UpdatePrimaryRegionResponse> UpdatePrimaryRegionAsyncInvoker(UpdatePrimaryRegionRequest updatePrimaryRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", updatePrimaryRegionRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/keys/{key_id}/update-primary-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrimaryRegionRequest);
            return new AsyncInvoker<UpdatePrimaryRegionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrimaryRegionResponse>);
        }
        
        /// <summary>
        /// 验证签名
        ///
        /// - 功能介绍：使用非对称密钥的私钥对消息或消息摘要进行签名验证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateSignatureResponse> ValidateSignatureAsync(ValidateSignatureRequest validateSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateSignatureRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ValidateSignatureResponse>(response);
        }

        public AsyncInvoker<ValidateSignatureResponse> ValidateSignatureAsyncInvoker(ValidateSignatureRequest validateSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateSignatureRequest);
            return new AsyncInvoker<ValidateSignatureResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateSignatureResponse>);
        }
        
        /// <summary>
        /// 校验消息验证码
        ///
        /// 功能介绍：校验消息验证码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<VerifyMacResponse> VerifyMacAsync(VerifyMacRequest verifyMacRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify-mac", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", verifyMacRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<VerifyMacResponse>(response);
        }

        public AsyncInvoker<VerifyMacResponse> VerifyMacAsyncInvoker(VerifyMacRequest verifyMacRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify-mac", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", verifyMacRequest);
            return new AsyncInvoker<VerifyMacResponse>(this, "POST", request, JsonUtils.DeSerialize<VerifyMacResponse>);
        }
        
        /// <summary>
        /// 查询指定版本信息
        ///
        /// - 功能介绍：查指定API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVersionResponse> ShowVersionAsync(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id", showVersionRequest.VersionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }

        public AsyncInvoker<ShowVersionResponse> ShowVersionAsyncInvoker(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id", showVersionRequest.VersionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            return new AsyncInvoker<ShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionResponse>);
        }
        
        /// <summary>
        /// 查询版本信息列表
        ///
        /// - 功能介绍：查询API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVersionsResponse> ShowVersionsAsync(ShowVersionsRequest showVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionsResponse>(response);
        }

        public AsyncInvoker<ShowVersionsResponse> ShowVersionsAsyncInvoker(ShowVersionsRequest showVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionsRequest);
            return new AsyncInvoker<ShowVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionsResponse>);
        }
        
    }
}
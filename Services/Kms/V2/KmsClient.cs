using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kms.V2.Model;

namespace HuaweiCloud.SDK.Kms.V2
{
    public partial class KmsClient : Client
    {
        public static ClientBuilder<KmsClient> NewBuilder()
        {
            return new ClientBuilder<KmsClient>();
        }

        
        /// <summary>
        /// 批量添加删除密钥标签
        ///
        /// - 功能介绍：批量添加删除密钥标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateKmsTagsResponse BatchCreateKmsTags(BatchCreateKmsTagsRequest batchCreateKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", batchCreateKmsTagsRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateKmsTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateKmsTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateKmsTagsResponse> BatchCreateKmsTagsInvoker(BatchCreateKmsTagsRequest batchCreateKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", batchCreateKmsTagsRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateKmsTagsRequest);
            return new SyncInvoker<BatchCreateKmsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateKmsTagsResponse>);
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
        public CancelGrantResponse CancelGrant(CancelGrantRequest cancelGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/revoke-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CancelGrantResponse>(response);
        }

        public SyncInvoker<CancelGrantResponse> CancelGrantInvoker(CancelGrantRequest cancelGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/revoke-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            return new SyncInvoker<CancelGrantResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CancelGrantResponse>);
        }
        
        /// <summary>
        /// 取消计划删除密钥
        ///
        /// - 功能介绍：取消计划删除密钥。
        /// - 说明：密钥处于“计划删除”状态才能取消计划删除密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest cancelKeyDeletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/cancel-key-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelKeyDeletionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CancelKeyDeletionResponse>(response);
        }

        public SyncInvoker<CancelKeyDeletionResponse> CancelKeyDeletionInvoker(CancelKeyDeletionRequest cancelKeyDeletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/cancel-key-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelKeyDeletionRequest);
            return new SyncInvoker<CancelKeyDeletionResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelKeyDeletionResponse>);
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
        public CancelSelfGrantResponse CancelSelfGrant(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/retire-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CancelSelfGrantResponse>(response);
        }

        public SyncInvoker<CancelSelfGrantResponse> CancelSelfGrantInvoker(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/retire-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            return new SyncInvoker<CancelSelfGrantResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CancelSelfGrantResponse>);
        }
        
        /// <summary>
        /// 创建数据密钥
        ///
        /// - 功能介绍：创建数据密钥，返回结果包含明文和密文。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatakeyResponse CreateDatakey(CreateDatakeyRequest createDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDatakeyResponse>(response);
        }

        public SyncInvoker<CreateDatakeyResponse> CreateDatakeyInvoker(CreateDatakeyRequest createDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            return new SyncInvoker<CreateDatakeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatakeyResponse>);
        }
        
        /// <summary>
        /// 创建不含明文数据密钥
        ///
        /// - 功能介绍：创建数据密钥，返回结果只包含密文。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatakeyWithoutPlaintextResponse CreateDatakeyWithoutPlaintext(CreateDatakeyWithoutPlaintextRequest createDatakeyWithoutPlaintextRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey-without-plaintext", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyWithoutPlaintextRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDatakeyWithoutPlaintextResponse>(response);
        }

        public SyncInvoker<CreateDatakeyWithoutPlaintextResponse> CreateDatakeyWithoutPlaintextInvoker(CreateDatakeyWithoutPlaintextRequest createDatakeyWithoutPlaintextRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey-without-plaintext", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyWithoutPlaintextRequest);
            return new SyncInvoker<CreateDatakeyWithoutPlaintextResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatakeyWithoutPlaintextResponse>);
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
        public CreateGrantResponse CreateGrant(CreateGrantRequest createGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGrantResponse>(response);
        }

        public SyncInvoker<CreateGrantResponse> CreateGrantInvoker(CreateGrantRequest createGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            return new SyncInvoker<CreateGrantResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGrantResponse>);
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
        public CreateKeyResponse CreateKey(CreateKeyRequest createKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKeyResponse>(response);
        }

        public SyncInvoker<CreateKeyResponse> CreateKeyInvoker(CreateKeyRequest createKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            return new SyncInvoker<CreateKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKeyResponse>);
        }
        
        /// <summary>
        /// 创建专属密钥库
        ///
        /// - \&quot;创建租户专属密钥库，专属密钥库使用DHSM实例作为密钥的存储\&quot;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKeyStoreResponse CreateKeyStore(CreateKeyStoreRequest createKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyStoreRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKeyStoreResponse>(response);
        }

        public SyncInvoker<CreateKeyStoreResponse> CreateKeyStoreInvoker(CreateKeyStoreRequest createKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyStoreRequest);
            return new SyncInvoker<CreateKeyStoreResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKeyStoreResponse>);
        }
        
        /// <summary>
        /// 添加密钥标签
        ///
        /// - 功能介绍：添加密钥标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKmsTagResponse CreateKmsTag(CreateKmsTagRequest createKmsTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", createKmsTagRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKmsTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateKmsTagResponse>(response);
        }

        public SyncInvoker<CreateKmsTagResponse> CreateKmsTagInvoker(CreateKmsTagRequest createKmsTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", createKmsTagRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKmsTagRequest);
            return new SyncInvoker<CreateKmsTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateKmsTagResponse>);
        }
        
        /// <summary>
        /// 获取密钥导入参数
        ///
        /// - 功能介绍：获取导入密钥的必要参数，包括密钥导入令牌和密钥加密公钥。
        /// - 说明：返回的公钥类型默认为RSA_2048。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateParametersForImportResponse CreateParametersForImport(CreateParametersForImportRequest createParametersForImportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-parameters-for-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createParametersForImportRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateParametersForImportResponse>(response);
        }

        public SyncInvoker<CreateParametersForImportResponse> CreateParametersForImportInvoker(CreateParametersForImportRequest createParametersForImportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-parameters-for-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createParametersForImportRequest);
            return new SyncInvoker<CreateParametersForImportResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateParametersForImportResponse>);
        }
        
        /// <summary>
        /// 创建随机数
        ///
        /// - 功能介绍：
        ///   生成8~8192bit范围内的随机数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRandomResponse CreateRandom(CreateRandomRequest createRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/gen-random", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRandomResponse>(response);
        }

        public SyncInvoker<CreateRandomResponse> CreateRandomInvoker(CreateRandomRequest createRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/gen-random", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            return new SyncInvoker<CreateRandomResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRandomResponse>);
        }
        
        /// <summary>
        /// 解密数据
        ///
        /// - 功能介绍：解密数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DecryptDataResponse DecryptData(DecryptDataRequest decryptDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DecryptDataResponse>(response);
        }

        public SyncInvoker<DecryptDataResponse> DecryptDataInvoker(DecryptDataRequest decryptDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            return new SyncInvoker<DecryptDataResponse>(this, "POST", request, JsonUtils.DeSerialize<DecryptDataResponse>);
        }
        
        /// <summary>
        /// 解密数据密钥
        ///
        /// - 功能介绍：解密数据密钥，用指定的主密钥解密数据密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DecryptDatakeyResponse DecryptDatakey(DecryptDatakeyRequest decryptDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DecryptDatakeyResponse>(response);
        }

        public SyncInvoker<DecryptDatakeyResponse> DecryptDatakeyInvoker(DecryptDatakeyRequest decryptDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            return new SyncInvoker<DecryptDatakeyResponse>(this, "POST", request, JsonUtils.DeSerialize<DecryptDatakeyResponse>);
        }
        
        /// <summary>
        /// 删除密钥材料
        ///
        /// - 功能介绍：删除密钥材料信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest deleteImportedKeyMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/delete-imported-key-material", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>(response);
        }

        public SyncInvoker<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialInvoker(DeleteImportedKeyMaterialRequest deleteImportedKeyMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/delete-imported-key-material", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            return new SyncInvoker<DeleteImportedKeyMaterialResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>);
        }
        
        /// <summary>
        /// 计划删除密钥
        ///
        /// - 功能介绍：计划多少天后删除密钥，可设置7天～1096天内删除密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKeyResponse DeleteKey(DeleteKeyRequest deleteKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/schedule-key-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteKeyResponse>(response);
        }

        public SyncInvoker<DeleteKeyResponse> DeleteKeyInvoker(DeleteKeyRequest deleteKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/schedule-key-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            return new SyncInvoker<DeleteKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteKeyResponse>);
        }
        
        /// <summary>
        /// 删除专属密钥库
        ///
        /// 删除租户专属密钥库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKeyStoreResponse DeleteKeyStore(DeleteKeyStoreRequest deleteKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", deleteKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeyStoreRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteKeyStoreResponse>(response);
        }

        public SyncInvoker<DeleteKeyStoreResponse> DeleteKeyStoreInvoker(DeleteKeyStoreRequest deleteKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", deleteKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeyStoreRequest);
            return new SyncInvoker<DeleteKeyStoreResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteKeyStoreResponse>);
        }
        
        /// <summary>
        /// 删除密钥标签
        ///
        /// - 功能介绍：删除密钥标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", deleteTagRequest.KeyId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public SyncInvoker<DeleteTagResponse> DeleteTagInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", deleteTagRequest.KeyId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new SyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 禁用密钥
        ///
        /// - 功能介绍：禁用密钥，密钥禁用后不可以使用。
        /// - 说明：密钥为启用状态才能禁用密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableKeyResponse DisableKey(DisableKeyRequest disableKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisableKeyResponse>(response);
        }

        public SyncInvoker<DisableKeyResponse> DisableKeyInvoker(DisableKeyRequest disableKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            return new SyncInvoker<DisableKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableKeyResponse>);
        }
        
        /// <summary>
        /// 关闭密钥轮换
        ///
        /// - 功能介绍：关闭用户主密钥轮换。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest disableKeyRotationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key-rotation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableKeyRotationResponse>(response);
        }

        public SyncInvoker<DisableKeyRotationResponse> DisableKeyRotationInvoker(DisableKeyRotationRequest disableKeyRotationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key-rotation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            return new SyncInvoker<DisableKeyRotationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableKeyRotationResponse>);
        }
        
        /// <summary>
        /// 禁用专属密钥库
        ///
        /// 禁用租户专属密钥库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableKeyStoreResponse DisableKeyStore(DisableKeyStoreRequest disableKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", disableKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableKeyStoreRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisableKeyStoreResponse>(response);
        }

        public SyncInvoker<DisableKeyStoreResponse> DisableKeyStoreInvoker(DisableKeyStoreRequest disableKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", disableKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableKeyStoreRequest);
            return new SyncInvoker<DisableKeyStoreResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableKeyStoreResponse>);
        }
        
        /// <summary>
        /// 启用密钥
        ///
        /// - 功能介绍：启用密钥，密钥启用后才可以使用。
        /// - 说明：密钥为禁用状态才能启用密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableKeyResponse EnableKey(EnableKeyRequest enableKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableKeyResponse>(response);
        }

        public SyncInvoker<EnableKeyResponse> EnableKeyInvoker(EnableKeyRequest enableKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            return new SyncInvoker<EnableKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableKeyResponse>);
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
        public EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest enableKeyRotationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key-rotation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableKeyRotationResponse>(response);
        }

        public SyncInvoker<EnableKeyRotationResponse> EnableKeyRotationInvoker(EnableKeyRotationRequest enableKeyRotationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key-rotation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            return new SyncInvoker<EnableKeyRotationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableKeyRotationResponse>);
        }
        
        /// <summary>
        /// 启用专属密钥库
        ///
        /// 启用租户专属密钥库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableKeyStoreResponse EnableKeyStore(EnableKeyStoreRequest enableKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", enableKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableKeyStoreRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableKeyStoreResponse>(response);
        }

        public SyncInvoker<EnableKeyStoreResponse> EnableKeyStoreInvoker(EnableKeyStoreRequest enableKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", enableKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableKeyStoreRequest);
            return new SyncInvoker<EnableKeyStoreResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableKeyStoreResponse>);
        }
        
        /// <summary>
        /// 加密数据
        ///
        /// - 功能介绍：加密数据，用指定的用户主密钥加密数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EncryptDataResponse EncryptData(EncryptDataRequest encryptDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EncryptDataResponse>(response);
        }

        public SyncInvoker<EncryptDataResponse> EncryptDataInvoker(EncryptDataRequest encryptDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            return new SyncInvoker<EncryptDataResponse>(this, "POST", request, JsonUtils.DeSerialize<EncryptDataResponse>);
        }
        
        /// <summary>
        /// 加密数据密钥
        ///
        /// - 功能介绍：加密数据密钥，用指定的主密钥加密数据密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EncryptDatakeyResponse EncryptDatakey(EncryptDatakeyRequest encryptDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EncryptDatakeyResponse>(response);
        }

        public SyncInvoker<EncryptDatakeyResponse> EncryptDatakeyInvoker(EncryptDatakeyRequest encryptDatakeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-datakey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            return new SyncInvoker<EncryptDatakeyResponse>(this, "POST", request, JsonUtils.DeSerialize<EncryptDatakeyResponse>);
        }
        
        /// <summary>
        /// 生成消息验证码
        ///
        /// 功能介绍：生成消息验证码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GenerateMacResponse GenerateMac(GenerateMacRequest generateMacRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/generate-mac", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateMacRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<GenerateMacResponse>(response);
        }

        public SyncInvoker<GenerateMacResponse> GenerateMacInvoker(GenerateMacRequest generateMacRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/generate-mac", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateMacRequest);
            return new SyncInvoker<GenerateMacResponse>(this, "POST", request, JsonUtils.DeSerialize<GenerateMacResponse>);
        }
        
        /// <summary>
        /// 导入密钥材料
        ///
        /// - 功能介绍：导入密钥材料。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest importKeyMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/import-key-material", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>(response);
        }

        public SyncInvoker<ImportKeyMaterialResponse> ImportKeyMaterialInvoker(ImportKeyMaterialRequest importKeyMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/import-key-material", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            return new SyncInvoker<ImportKeyMaterialResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>);
        }
        
        /// <summary>
        /// 查询授权列表
        ///
        /// - 功能介绍：查询密钥的授权列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGrantsResponse ListGrants(ListGrantsRequest listGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
        }

        public SyncInvoker<ListGrantsResponse> ListGrantsInvoker(ListGrantsRequest listGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            return new SyncInvoker<ListGrantsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGrantsResponse>);
        }
        
        /// <summary>
        /// 查询密钥信息
        ///
        /// - 功能介绍：查询密钥详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeyDetailResponse ListKeyDetail(ListKeyDetailRequest listKeyDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/describe-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListKeyDetailResponse>(response);
        }

        public SyncInvoker<ListKeyDetailResponse> ListKeyDetailInvoker(ListKeyDetailRequest listKeyDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/describe-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            return new SyncInvoker<ListKeyDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ListKeyDetailResponse>);
        }
        
        /// <summary>
        /// 查询专属密钥库列表
        ///
        /// 查询租户专属密钥库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeyStoresResponse ListKeyStores(ListKeyStoresRequest listKeyStoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyStoresRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKeyStoresResponse>(response);
        }

        public SyncInvoker<ListKeyStoresResponse> ListKeyStoresInvoker(ListKeyStoresRequest listKeyStoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyStoresRequest);
            return new SyncInvoker<ListKeyStoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeyStoresResponse>);
        }
        
        /// <summary>
        /// 查询密钥列表
        ///
        /// - 功能介绍：查询用户所有密钥列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeysResponse ListKeys(ListKeysRequest listKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListKeysResponse>(response);
        }

        public SyncInvoker<ListKeysResponse> ListKeysInvoker(ListKeysRequest listKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            return new SyncInvoker<ListKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<ListKeysResponse>);
        }
        
        /// <summary>
        /// 查询密钥实例
        ///
        /// - 功能介绍：查询密钥实例。通过标签过滤，查询指定用户主密钥的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKmsByTagsResponse ListKmsByTags(ListKmsByTagsRequest listKmsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances", listKmsByTagsRequest.ResourceInstances.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{resource_instances}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListKmsByTagsResponse>(response);
        }

        public SyncInvoker<ListKmsByTagsResponse> ListKmsByTagsInvoker(ListKmsByTagsRequest listKmsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances", listKmsByTagsRequest.ResourceInstances.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{resource_instances}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            return new SyncInvoker<ListKmsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListKmsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// - 功能介绍：查询用户在指定项目下的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKmsTagsResponse ListKmsTags(ListKmsTagsRequest listKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKmsTagsResponse>(response);
        }

        public SyncInvoker<ListKmsTagsResponse> ListKmsTagsInvoker(ListKmsTagsRequest listKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            return new SyncInvoker<ListKmsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKmsTagsResponse>);
        }
        
        /// <summary>
        /// 查询可退役授权列表
        ///
        /// - 功能介绍：查询用户可以退役的授权列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest listRetirableGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-retirable-grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListRetirableGrantsResponse>(response);
        }

        public SyncInvoker<ListRetirableGrantsResponse> ListRetirableGrantsInvoker(ListRetirableGrantsRequest listRetirableGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-retirable-grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            return new SyncInvoker<ListRetirableGrantsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRetirableGrantsResponse>);
        }
        
        /// <summary>
        /// 查询跨区域密钥所支持的区域
        ///
        /// - 功能介绍：查询跨区域密钥所支持的区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSupportRegionsResponse ListSupportRegions(ListSupportRegionsRequest listSupportRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSupportRegionsResponse>(response);
        }

        public SyncInvoker<ListSupportRegionsResponse> ListSupportRegionsInvoker(ListSupportRegionsRequest listSupportRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportRegionsRequest);
            return new SyncInvoker<ListSupportRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportRegionsResponse>);
        }
        
        /// <summary>
        /// 复制密钥到指定区域
        ///
        /// 将本区域的密钥复制到指定区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ReplicateKeyResponse ReplicateKey(ReplicateKeyRequest replicateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", replicateKeyRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/keys/{key_id}/replicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", replicateKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ReplicateKeyResponse>(response);
        }

        public SyncInvoker<ReplicateKeyResponse> ReplicateKeyInvoker(ReplicateKeyRequest replicateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", replicateKeyRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/keys/{key_id}/replicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", replicateKeyRequest);
            return new SyncInvoker<ReplicateKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ReplicateKeyResponse>);
        }
        
        /// <summary>
        /// 查询密钥轮换状态
        ///
        /// - 功能介绍：查询用户主密钥轮换状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKeyRotationStatusResponse ShowKeyRotationStatus(ShowKeyRotationStatusRequest showKeyRotationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-key-rotation-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>(response);
        }

        public SyncInvoker<ShowKeyRotationStatusResponse> ShowKeyRotationStatusInvoker(ShowKeyRotationStatusRequest showKeyRotationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-key-rotation-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            return new SyncInvoker<ShowKeyRotationStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>);
        }
        
        /// <summary>
        /// 获取专属密钥库
        ///
        /// 获取租户专属密钥库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKeyStoreResponse ShowKeyStore(ShowKeyStoreRequest showKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", showKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeyStoreRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKeyStoreResponse>(response);
        }

        public SyncInvoker<ShowKeyStoreResponse> ShowKeyStoreInvoker(ShowKeyStoreRequest showKeyStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", showKeyStoreRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeyStoreRequest);
            return new SyncInvoker<ShowKeyStoreResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKeyStoreResponse>);
        }
        
        /// <summary>
        /// 查询密钥标签
        ///
        /// - 功能介绍：查询密钥标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKmsTagsResponse ShowKmsTags(ShowKmsTagsRequest showKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", showKmsTagsRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKmsTagsResponse>(response);
        }

        public SyncInvoker<ShowKmsTagsResponse> ShowKmsTagsInvoker(ShowKmsTagsRequest showKmsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", showKmsTagsRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            return new SyncInvoker<ShowKmsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKmsTagsResponse>);
        }
        
        /// <summary>
        /// 查询公钥信息
        ///
        /// - 查询用户指定非对称密钥的公钥信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicKeyResponse ShowPublicKey(ShowPublicKeyRequest showPublicKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-publickey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublicKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowPublicKeyResponse>(response);
        }

        public SyncInvoker<ShowPublicKeyResponse> ShowPublicKeyInvoker(ShowPublicKeyRequest showPublicKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-publickey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublicKeyRequest);
            return new SyncInvoker<ShowPublicKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowPublicKeyResponse>);
        }
        
        /// <summary>
        /// 查询实例数
        ///
        /// - 功能介绍：查询实例数，获取用户已经创建的用户主密钥数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserInstancesResponse ShowUserInstances(ShowUserInstancesRequest showUserInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserInstancesResponse>(response);
        }

        public SyncInvoker<ShowUserInstancesResponse> ShowUserInstancesInvoker(ShowUserInstancesRequest showUserInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            return new SyncInvoker<ShowUserInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserInstancesResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// - 功能介绍：查询配额，查询用户可以创建的用户主密钥配额总数及当前使用量信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserQuotasResponse ShowUserQuotas(ShowUserQuotasRequest showUserQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserQuotasResponse>(response);
        }

        public SyncInvoker<ShowUserQuotasResponse> ShowUserQuotasInvoker(ShowUserQuotasRequest showUserQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            return new SyncInvoker<ShowUserQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserQuotasResponse>);
        }
        
        /// <summary>
        /// 签名数据
        ///
        /// - 功能介绍：使用非对称密钥的私钥对消息或消息摘要进行数字签名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SignResponse Sign(SignRequest signRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/sign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", signRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SignResponse>(response);
        }

        public SyncInvoker<SignResponse> SignInvoker(SignRequest signRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/sign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", signRequest);
            return new SyncInvoker<SignResponse>(this, "POST", request, JsonUtils.DeSerialize<SignResponse>);
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
        public UpdateKeyAliasResponse UpdateKeyAlias(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyAliasRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateKeyAliasResponse>(response);
        }

        public SyncInvoker<UpdateKeyAliasResponse> UpdateKeyAliasInvoker(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyAliasRequest);
            return new SyncInvoker<UpdateKeyAliasResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateKeyAliasResponse>);
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
        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>(response);
        }

        public SyncInvoker<UpdateKeyDescriptionResponse> UpdateKeyDescriptionInvoker(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            return new SyncInvoker<UpdateKeyDescriptionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>);
        }
        
        /// <summary>
        /// 修改密钥轮换周期
        ///
        /// - 功能介绍：修改用户主密钥轮换周期。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKeyRotationIntervalResponse UpdateKeyRotationInterval(UpdateKeyRotationIntervalRequest updateKeyRotationIntervalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-rotation-interval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>(response);
        }

        public SyncInvoker<UpdateKeyRotationIntervalResponse> UpdateKeyRotationIntervalInvoker(UpdateKeyRotationIntervalRequest updateKeyRotationIntervalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-rotation-interval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            return new SyncInvoker<UpdateKeyRotationIntervalResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>);
        }
        
        /// <summary>
        /// 修改密钥所属的主区域
        ///
        /// 修改密钥所属的主区域。修改后当前区域会变为副本区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrimaryRegionResponse UpdatePrimaryRegion(UpdatePrimaryRegionRequest updatePrimaryRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", updatePrimaryRegionRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/keys/{key_id}/update-primary-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrimaryRegionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrimaryRegionResponse>(response);
        }

        public SyncInvoker<UpdatePrimaryRegionResponse> UpdatePrimaryRegionInvoker(UpdatePrimaryRegionRequest updatePrimaryRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id", updatePrimaryRegionRequest.KeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kms/keys/{key_id}/update-primary-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrimaryRegionRequest);
            return new SyncInvoker<UpdatePrimaryRegionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrimaryRegionResponse>);
        }
        
        /// <summary>
        /// 验证签名
        ///
        /// - 功能介绍：使用非对称密钥的私钥对消息或消息摘要进行签名验证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateSignatureResponse ValidateSignature(ValidateSignatureRequest validateSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateSignatureRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ValidateSignatureResponse>(response);
        }

        public SyncInvoker<ValidateSignatureResponse> ValidateSignatureInvoker(ValidateSignatureRequest validateSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateSignatureRequest);
            return new SyncInvoker<ValidateSignatureResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateSignatureResponse>);
        }
        
        /// <summary>
        /// 校验消息验证码
        ///
        /// 功能介绍：校验消息验证码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public VerifyMacResponse VerifyMac(VerifyMacRequest verifyMacRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify-mac", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", verifyMacRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<VerifyMacResponse>(response);
        }

        public SyncInvoker<VerifyMacResponse> VerifyMacInvoker(VerifyMacRequest verifyMacRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify-mac", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", verifyMacRequest);
            return new SyncInvoker<VerifyMacResponse>(this, "POST", request, JsonUtils.DeSerialize<VerifyMacResponse>);
        }
        
        /// <summary>
        /// 查询指定版本信息
        ///
        /// - 功能介绍：查指定API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVersionResponse ShowVersion(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id", showVersionRequest.VersionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }

        public SyncInvoker<ShowVersionResponse> ShowVersionInvoker(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id", showVersionRequest.VersionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            return new SyncInvoker<ShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionResponse>);
        }
        
        /// <summary>
        /// 查询版本信息列表
        ///
        /// - 功能介绍：查询API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVersionsResponse ShowVersions(ShowVersionsRequest showVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionsResponse>(response);
        }

        public SyncInvoker<ShowVersionsResponse> ShowVersionsInvoker(ShowVersionsRequest showVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionsRequest);
            return new SyncInvoker<ShowVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionsResponse>);
        }
        
    }
}
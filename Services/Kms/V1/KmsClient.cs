using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace HuaweiCloud.SDK.Kms.V1
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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public BatchCreateKmsTagsResponse BatchCreateKmsTags(BatchCreateKmsTagsRequest batchCreateKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , batchCreateKmsTagsRequest.KeyId.ToString());
            urlParam.Add("version_id" , batchCreateKmsTagsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{key_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateKmsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateKmsTagsResponse>(response);
        }
        
        /// <summary>
        /// 撤销授权
        ///
        /// - 功能介绍：撤销授权，授权用户撤销被授权用户操作密钥的权限。
        /// - 说明：
        ///    - 创建密钥的用户才能撤销该密钥授权。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CancelGrantResponse CancelGrant(CancelGrantRequest cancelGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , cancelGrantRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/revoke-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CancelGrantResponse>(response);
        }
        
        /// <summary>
        /// 取消计划删除密钥
        ///
        /// - 功能介绍：取消计划删除密钥。
        /// 
        /// - 说明：密钥处于“计划删除”状态才能取消计划删除密钥。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest cancelKeyDeletionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , cancelKeyDeletionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/cancel-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelKeyDeletionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CancelKeyDeletionResponse>(response);
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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CancelSelfGrantResponse CancelSelfGrant(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , cancelSelfGrantRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/retire-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CancelSelfGrantResponse>(response);
        }
        
        /// <summary>
        /// 创建数据密钥
        ///
        /// - 功能介绍：创建数据密钥，返回结果包含明文和密文。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateDatakeyResponse CreateDatakey(CreateDatakeyRequest createDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createDatakeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/create-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyResponse>(response);
        }
        
        /// <summary>
        /// 创建不含明文数据密钥
        ///
        /// - 功能介绍：创建数据密钥，返回结果只包含密文。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateDatakeyWithoutPlaintextResponse CreateDatakeyWithoutPlaintext(CreateDatakeyWithoutPlaintextRequest createDatakeyWithoutPlaintextRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createDatakeyWithoutPlaintextRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/create-datakey-without-plaintext",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyWithoutPlaintextRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyWithoutPlaintextResponse>(response);
        }
        
        /// <summary>
        /// 创建授权
        ///
        /// - 功能介绍：创建授权，被授权用户可以对授权密钥进行操作。
        /// - 说明：
        ///    - 服务默认主密钥（密钥别名后缀为“/default”）不可以授权。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateGrantResponse CreateGrant(CreateGrantRequest createGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createGrantRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/create-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGrantResponse>(response);
        }
        
        /// <summary>
        /// 创建密钥
        ///
        /// 创建用户主密钥，用户主密钥可以为对称密钥或非对称密钥。
        /// - 对称密钥为长度为256位AES密钥，可用于小量数据的加密或者用于加密数据密钥。
        /// - 非对称密钥可以为RSA密钥对或者ECC密钥对，可用于数字签名及验签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateKeyResponse CreateKey(CreateKeyRequest createKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/create-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKeyResponse>(response);
        }
        
        /// <summary>
        /// 添加密钥标签
        ///
        /// - 功能介绍：添加密钥标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateKmsTagResponse CreateKmsTag(CreateKmsTagRequest createKmsTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createKmsTagRequest.VersionId.ToString());
            urlParam.Add("key_id" , createKmsTagRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKmsTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateKmsTagResponse>(response);
        }
        
        /// <summary>
        /// 获取密钥导入参数
        ///
        /// - 功能介绍：获取导入密钥的必要参数，包括密钥导入令牌和密钥加密公钥。
        /// - 说明：返回的公钥类型默认为RSA_2048。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateParametersForImportResponse CreateParametersForImport(CreateParametersForImportRequest createParametersForImportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createParametersForImportRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/get-parameters-for-import",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createParametersForImportRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateParametersForImportResponse>(response);
        }
        
        /// <summary>
        /// 创建随机数
        ///
        /// - 功能介绍：
        ///   生成8~8192bit范围内的随机数。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateRandomResponse CreateRandom(CreateRandomRequest createRandomRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createRandomRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/gen-random",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRandomResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据
        ///
        /// 创建新的凭据，并将凭据值存入凭据的初始版本。
        /// 
        /// 
        /// 凭据管理服务将凭据值加密后，存储在凭据对象下的版本中。每个版本可与多个凭据版本状态相关联，凭据版本状态用于标识凭据版本处于的阶段，没有版本状态标记的版本视为已弃用，可用凭据管理服务自动删除。
        /// 
        /// 初始版本的状态被标记为SYSCURRENT。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateSecretResponse CreateSecret(CreateSecretRequest createSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据版本
        ///
        /// 在指定的凭据中，创建一个新的凭据版本，用于加密保管新的凭据值。默认情况下，新创建的凭据版本被标记为SYSCURRENT状态，而SYSCURRENT标记的前一个凭据版本被标记为SYSPREVIOUS状态。您可以通过指定VersionStage参数来覆盖默认行为。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateSecretVersionResponse CreateSecretVersion(CreateSecretVersionRequest createSecretVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , createSecretVersionRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretVersionResponse>(response);
        }
        
        /// <summary>
        /// 解密数据
        ///
        /// - 功能介绍：解密数据。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DecryptDataResponse DecryptData(DecryptDataRequest decryptDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , decryptDataRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/decrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DecryptDataResponse>(response);
        }
        
        /// <summary>
        /// 解密数据密钥
        ///
        /// - 功能介绍：解密数据密钥，用指定的主密钥解密数据密钥。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DecryptDatakeyResponse DecryptDatakey(DecryptDatakeyRequest decryptDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , decryptDatakeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/decrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DecryptDatakeyResponse>(response);
        }
        
        /// <summary>
        /// 删除密钥材料
        ///
        /// - 功能介绍：删除密钥材料信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest deleteImportedKeyMaterialRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , deleteImportedKeyMaterialRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/delete-imported-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>(response);
        }
        
        /// <summary>
        /// 计划删除密钥
        ///
        /// - 功能介绍：计划多少天后删除密钥，可设置7天～1096天内删除密钥。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteKeyResponse DeleteKey(DeleteKeyRequest deleteKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , deleteKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/schedule-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DeleteKeyResponse>(response);
        }
        
        /// <summary>
        /// 立即删除凭据
        ///
        /// 立即删除指定的凭据，且无法恢复。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest deleteSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , deleteSecretRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecretResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据的定时删除任务
        ///
        /// 指定延迟删除时间，创建删除凭据的定时任务，可设置7~30天的的延迟删除时间。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteSecretForScheduleResponse DeleteSecretForSchedule(DeleteSecretForScheduleRequest deleteSecretForScheduleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , deleteSecretForScheduleRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/scheduled-deleted-tasks/create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSecretForScheduleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DeleteSecretForScheduleResponse>(response);
        }
        
        /// <summary>
        /// 删除凭据的版本状态
        ///
        /// 删除指定的凭据版本状态。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteSecretStageResponse DeleteSecretStage(DeleteSecretStageRequest deleteSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , deleteSecretStageRequest.SecretId.ToString());
            urlParam.Add("stage_name" , deleteSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretStageRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 删除密钥标签
        ///
        /// - 功能介绍：删除密钥标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , deleteTagRequest.KeyId.ToString());
            urlParam.Add("key" , deleteTagRequest.Key.ToString());
            urlParam.Add("version_id" , deleteTagRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{key_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }
        
        /// <summary>
        /// 禁用密钥
        ///
        /// - 功能介绍：禁用密钥，密钥禁用后不可以使用。
        /// 
        /// - 说明：密钥为启用状态才能禁用密钥。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DisableKeyResponse DisableKey(DisableKeyRequest disableKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , disableKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/disable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisableKeyResponse>(response);
        }
        
        /// <summary>
        /// 关闭密钥轮换
        ///
        /// - 功能介绍：关闭用户主密钥轮换。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest disableKeyRotationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , disableKeyRotationRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/disable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DisableKeyRotationResponse>(response);
        }
        
        /// <summary>
        /// 启用密钥
        ///
        /// - 功能介绍：启用密钥，密钥启用后才可以使用。
        /// 
        /// - 说明：密钥为禁用状态才能启用密钥。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public EnableKeyResponse EnableKey(EnableKeyRequest enableKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , enableKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/enable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EnableKeyResponse>(response);
        }
        
        /// <summary>
        /// 开启密钥轮换
        ///
        /// - 功能介绍：开启用户主密钥轮换。
        /// - 说明：
        ///   - 开启密钥轮换后，默认轮询间隔时间为365天。
        ///   - 默认主密钥及外部导入密钥不支持轮换操作。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest enableKeyRotationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , enableKeyRotationRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/enable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<EnableKeyRotationResponse>(response);
        }
        
        /// <summary>
        /// 加密数据
        ///
        /// - 功能介绍：加密数据，用指定的用户主密钥加密数据。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public EncryptDataResponse EncryptData(EncryptDataRequest encryptDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , encryptDataRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/encrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EncryptDataResponse>(response);
        }
        
        /// <summary>
        /// 加密数据密钥
        ///
        /// - 功能介绍：加密数据密钥，用指定的主密钥加密数据密钥。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public EncryptDatakeyResponse EncryptDatakey(EncryptDatakeyRequest encryptDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , encryptDatakeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/encrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EncryptDatakeyResponse>(response);
        }
        
        /// <summary>
        /// 导入密钥材料
        ///
        /// - 功能介绍：导入密钥材料。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest importKeyMaterialRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , importKeyMaterialRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/import-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>(response);
        }
        
        /// <summary>
        /// 查询授权列表
        ///
        /// - 功能介绍：查询密钥的授权列表。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListGrantsResponse ListGrants(ListGrantsRequest listGrantsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listGrantsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/list-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥信息
        ///
        /// - 功能介绍：查询密钥详细信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListKeyDetailResponse ListKeyDetail(ListKeyDetailRequest listKeyDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listKeyDetailRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/describe-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKeyDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥列表
        ///
        /// - 功能介绍：查询用户所有密钥列表。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListKeysResponse ListKeys(ListKeysRequest listKeysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listKeysRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/list-keys",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKeysResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥实例
        ///
        /// - 功能介绍：查询密钥实例。通过标签过滤，查询指定用户主密钥的详细信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListKmsByTagsResponse ListKmsByTags(ListKmsByTagsRequest listKmsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances" , listKmsByTagsRequest.ResourceInstances.ToString());
            urlParam.Add("version_id" , listKmsByTagsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{resource_instances}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKmsByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// - 功能介绍：查询用户在指定项目下的所有标签集合。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListKmsTagsResponse ListKmsTags(ListKmsTagsRequest listKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listKmsTagsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKmsTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询可退役授权列表
        ///
        /// - 功能介绍：查询用户可以退役的授权列表。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest listRetirableGrantsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listRetirableGrantsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/list-retirable-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListRetirableGrantsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本状态
        ///
        /// 查询指定凭据版本状态标记的版本信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListSecretStageResponse ListSecretStage(ListSecretStageRequest listSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , listSecretStageRequest.SecretId.ToString());
            urlParam.Add("stage_name" , listSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretStageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本列表
        ///
        /// 查询指定凭据下的版本列表信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListSecretVersionsResponse ListSecretVersions(ListSecretVersionsRequest listSecretVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , listSecretVersionsRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecretVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据列表
        ///
        /// 查询当前用户在本项目下创建的所有凭据。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListSecretsResponse ListSecrets(ListSecretsRequest listSecretsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecretsResponse>(response);
        }
        
        /// <summary>
        /// 取消凭据的定时删除任务
        ///
        /// 取消凭据的定时删除任务，凭据对象恢复可使用状态。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public RestoreSecretResponse RestoreSecret(RestoreSecretRequest restoreSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , restoreSecretRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/scheduled-deleted-tasks/cancel",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestoreSecretResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥轮换状态
        ///
        /// - 功能介绍：查询用户主密钥轮换状态。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowKeyRotationStatusResponse ShowKeyRotationStatus(ShowKeyRotationStatusRequest showKeyRotationStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showKeyRotationStatusRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/get-key-rotation-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥标签
        ///
        /// - 功能介绍：查询密钥标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowKmsTagsResponse ShowKmsTags(ShowKmsTagsRequest showKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showKmsTagsRequest.VersionId.ToString());
            urlParam.Add("key_id" , showKmsTagsRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowKmsTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询公钥信息
        ///
        /// - 查询用户指定非对称密钥的公钥信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowPublicKeyResponse ShowPublicKey(ShowPublicKeyRequest showPublicKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showPublicKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/get-publickey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublicKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowPublicKeyResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据
        ///
        /// 查询指定凭据的信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowSecretResponse ShowSecret(ShowSecretRequest showSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , showSecretRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecretResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本与凭据值
        ///
        /// 查询指定凭据版本的信息和版本中的明文凭据值，只能查询ENABLED状态的凭据。
        /// 通过/v1/{project_id}/secrets/{secret_id}/versions/latest可访问凭据最新版本的凭据值。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowSecretVersionResponse ShowSecretVersion(ShowSecretVersionRequest showSecretVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , showSecretVersionRequest.SecretId.ToString());
            urlParam.Add("version_id" , showSecretVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/versions/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecretVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询实例数
        ///
        /// - 功能介绍：查询实例数，获取用户已经创建的用户主密钥数量。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowUserInstancesResponse ShowUserInstances(ShowUserInstancesRequest showUserInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showUserInstancesRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/user-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUserInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// - 功能介绍：查询配额，查询用户可以创建的用户主密钥配额总数及当前使用量信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowUserQuotasResponse ShowUserQuotas(ShowUserQuotasRequest showUserQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showUserQuotasRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/user-quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUserQuotasResponse>(response);
        }
        
        /// <summary>
        /// 签名数据
        ///
        /// - 功能介绍：使用非对称密钥的私钥对消息或消息摘要进行数字签名。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public SignResponse Sign(SignRequest signRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , signRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/sign",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", signRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SignResponse>(response);
        }
        
        /// <summary>
        /// 修改密钥别名
        ///
        /// - 功能介绍：修改用户主密钥别名。
        /// - 说明：
        ///    - 服务默认主密钥（密钥别名后缀为“/default”）不可以修改。
        ///    - 密钥处于“计划删除”状态，密钥别名不可以修改。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateKeyAliasResponse UpdateKeyAlias(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , updateKeyAliasRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/update-key-alias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyAliasResponse>(response);
        }
        
        /// <summary>
        /// 修改密钥描述
        ///
        /// - 功能介绍：修改用户主密钥描述信息。
        /// - 说明：
        ///    - 服务默认主密钥（密钥别名后缀为“/default”）不可以修改。
        ///    - 密钥处于“计划删除”状态，密钥描述不可以修改。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , updateKeyDescriptionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/update-key-description",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>(response);
        }
        
        /// <summary>
        /// 修改密钥轮换周期
        ///
        /// - 功能介绍：修改用户主密钥轮换周期。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateKeyRotationIntervalResponse UpdateKeyRotationInterval(UpdateKeyRotationIntervalRequest updateKeyRotationIntervalRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , updateKeyRotationIntervalRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/update-key-rotation-interval",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>(response);
        }
        
        /// <summary>
        /// 更新凭据
        ///
        /// 更新指定凭据的元数据信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateSecretResponse UpdateSecret(UpdateSecretRequest updateSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , updateSecretRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecretResponse>(response);
        }
        
        /// <summary>
        /// 更新凭据的版本状态
        ///
        /// 更新凭据的版本状态。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateSecretStageResponse UpdateSecretStage(UpdateSecretStageRequest updateSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , updateSecretStageRequest.SecretId.ToString());
            urlParam.Add("stage_name" , updateSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretStageRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 验证签名
        ///
        /// - 功能介绍：使用非对称密钥的私钥对消息或消息摘要进行数字签名。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ValidateSignatureResponse ValidateSignature(ValidateSignatureRequest validateSignatureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , validateSignatureRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/verify",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateSignatureRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ValidateSignatureResponse>(response);
        }
        
        /// <summary>
        /// 查询指定版本信息
        ///
        /// - 功能介绍：查指定API版本信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowVersionResponse ShowVersion(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询版本信息列表
        ///
        /// - 功能介绍：查询API版本信息列表。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowVersionsResponse ShowVersions(ShowVersionsRequest showVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionsResponse>(response);
        }
        
    }
}
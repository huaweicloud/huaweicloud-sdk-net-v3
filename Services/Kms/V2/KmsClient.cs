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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , batchCreateKmsTagsRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/action",urlParam);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelGrantResponse CancelGrant(CancelGrantRequest cancelGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/revoke-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CancelGrantResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/cancel-key-deletion",urlParam);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelSelfGrantResponse CancelSelfGrant(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/retire-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CancelSelfGrantResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey-without-plaintext",urlParam);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGrantResponse CreateGrant(CreateGrantRequest createGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGrantResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKeyStoreResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , createKmsTagRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags",urlParam);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateParametersForImportResponse CreateParametersForImport(CreateParametersForImportRequest createParametersForImportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-parameters-for-import",urlParam);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRandomResponse CreateRandom(CreateRandomRequest createRandomRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/gen-random",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRandomResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DecryptDataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DecryptDatakeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/delete-imported-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/schedule-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DeleteKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , deleteKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteKeyStoreResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , deleteTagRequest.KeyId.ToString());
            urlParam.Add("key" , deleteTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisableKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DisableKeyRotationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , disableKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisableKeyStoreResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EnableKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<EnableKeyRotationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , enableKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EnableKeyStoreResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EncryptDataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EncryptDatakeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/import-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/describe-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKeyDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyStoresRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKeyStoresResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-keys",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKeysResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances" , listKmsByTagsRequest.ResourceInstances.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{resource_instances}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKmsByTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKmsTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-retirable-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListRetirableGrantsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-key-rotation-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , showKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowKeyStoreResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , showKmsTagsRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowKmsTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-publickey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublicKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowPublicKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUserInstancesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUserQuotasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/sign",urlParam);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKeyAliasResponse UpdateKeyAlias(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-alias",urlParam);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-description",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-rotation-interval",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateSignatureRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ValidateSignatureResponse>(response);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
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
using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IoTDM.V5.Model;

namespace HuaweiCloud.SDK.IoTDM.V5
{
    public partial class IoTDMClient : Client
    {
        public static ClientBuilder<IoTDMClient> NewBuilder()
        {
            return new ClientBuilder<IoTDMClient>();
        }

        
        /// <summary>
        /// 添加实例标签
        ///
        /// 添加实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BindInstanceTagsResponse BindInstanceTags(BindInstanceTagsRequest bindInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", bindInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}/bind-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", bindInstanceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BindInstanceTagsResponse>(response);
        }

        public SyncInvoker<BindInstanceTagsResponse> BindInstanceTagsInvoker(BindInstanceTagsRequest bindInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", bindInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}/bind-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", bindInstanceTagsRequest);
            return new SyncInvoker<BindInstanceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BindInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 修改实例计费模式
        ///
        /// 修改设备接入实例的计费模式，支持将按需计费模式修改为包年/包月计费模式。
        /// 接口约束：当前实例的规格支持包年/包月计费模式时，才可以修改实例的计费模式为包年/包月。支持的实例规格请参见[[产品规格说明](https://support.huaweicloud.com/productdesc-iothub/iot_04_0014.html)](tag:hws)[[产品规格说明](https://support.huaweicloud.com/intl/zh-cn/productdesc-iothub/iot_04_0014.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeInstanceChargeModeResponse ChangeInstanceChargeMode(ChangeInstanceChargeModeRequest changeInstanceChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeInstanceChargeModeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeInstanceChargeModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeInstanceChargeModeResponse>(response);
        }

        public SyncInvoker<ChangeInstanceChargeModeResponse> ChangeInstanceChargeModeInvoker(ChangeInstanceChargeModeRequest changeInstanceChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeInstanceChargeModeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeInstanceChargeModeRequest);
            return new SyncInvoker<ChangeInstanceChargeModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeInstanceChargeModeResponse>);
        }
        
        /// <summary>
        /// 创建设备接入实例
        ///
        /// 用户可以调用此接口创建一个设备接入实例。支持的实例规格请参见[[产品规格说明](https://support.huaweicloud.com/productdesc-iothub/iot_04_0014.html)](tag:hws)[[产品规格说明](https://support.huaweicloud.com/intl/zh-cn/productdesc-iothub/iot_04_0014.html)](tag:hws_hk)。
        /// [接口约束：
        /// - 请保证账户余额充足，此接口无法使用优惠券支付，在创建包年/包月实例时，若余额不足会创建一个待支付订单。
        /// - 若想使用优惠券，请将请求中的is_auto_pay字段设置为false，参考[\&quot;支付包年/包月产品订单\&quot;](https://support.huaweicloud.com/api-bpconsole/api_order_00016.html#section0)进行支付，或者在华为云官网页面使用优惠券进行支付。
        /// - 如果您需要退订包年/包月资源，请参考[\&quot;退订包年/包月资源\&quot;](https://support.huaweicloud.com/api-bpconsole/api_order_00019.html)。](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public SyncInvoker<CreateInstanceResponse> CreateInstanceInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            return new SyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 删除实例
        ///
        /// 删除设备接入实例。约束：此接口仅支持删除按需计费的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResponse>(response);
        }

        public SyncInvoker<DeleteInstanceResponse> DeleteInstanceInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new SyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 用户可以调用此接口查询设备接入实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public SyncInvoker<ListInstancesResponse> ListInstancesInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new SyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 修改实例规格信息
        ///
        /// 修改设备接入实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeInstanceResponse ResizeInstance(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public SyncInvoker<ResizeInstanceResponse> ResizeInstanceInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceRequest);
            return new SyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
        }
        
        /// <summary>
        /// 查询实例详情
        ///
        /// 查询设备接入实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceResponse ShowInstance(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public SyncInvoker<ShowInstanceResponse> ShowInstanceInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new SyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
        }
        
        /// <summary>
        /// 删除实例标签
        ///
        /// 删除实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnbindInstanceTagsResponse UnbindInstanceTags(UnbindInstanceTagsRequest unbindInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", unbindInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}/unbind-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", unbindInstanceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UnbindInstanceTagsResponse>(response);
        }

        public SyncInvoker<UnbindInstanceTagsResponse> UnbindInstanceTagsInvoker(UnbindInstanceTagsRequest unbindInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", unbindInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}/unbind-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", unbindInstanceTagsRequest);
            return new SyncInvoker<UnbindInstanceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UnbindInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 修改实例信息
        ///
        /// 修改设备接入实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceResponse>(response);
        }

        public SyncInvoker<UpdateInstanceResponse> UpdateInstanceInvoker(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/iotda-instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceRequest);
            return new SyncInvoker<UpdateInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceResponse>);
        }
        
    }
}
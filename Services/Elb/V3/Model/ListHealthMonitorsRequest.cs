using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListHealthMonitorsRequest 
    {

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明： - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 每页返回的个数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 是否反向查询。  取值： - true：查询上一页。 - false：查询下一页，默认。  使用说明： - 必须与limit一起使用。 - 当page_reverse&#x3D;true时，若要查询上一页，marker取值为当前页返回值的previous_marker。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 健康检查ID。  支持多值查询，查询条件格式：*id&#x3D;xxx&amp;id&#x3D;xxx****。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 健康检查端口号。  支持多值查询，查询条件格式：***monitor_port&#x3D;xxx&amp;monitor_port&#x3D;xxx***。
        /// </summary>
        [SDKProperty("monitor_port", IsQuery = true)]
        [JsonProperty("monitor_port", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> MonitorPort { get; set; }

        /// <summary>
        /// 发送健康检查请求的域名。  取值：以数字或字母开头，只能包含数字、字母、’-’、’.’。  支持多值查询，查询条件格式：**domain_name&#x3D;xxx&amp;domain_name&#x3D;xxx**。
        /// </summary>
        [SDKProperty("domain_name", IsQuery = true)]
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DomainName { get; set; }

        /// <summary>
        /// 健康检查名称。  支持多值查询，查询条件格式：*name&#x3D;xxx&amp;name&#x3D;xxx*。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 健康检查间隔。  取值：1-50s。  支持多值查询，查询条件格式：*delay&#x3D;xxx&amp;delay&#x3D;xxx*。
        /// </summary>
        [SDKProperty("delay", IsQuery = true)]
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Delay { get; set; }

        /// <summary>
        /// 健康检查连续成功多少次后，将后端服务器的健康检查状态由OFFLINE判定为ONLINE。取值范围：1-10。  支持多值查询，查询条件格式：*******max_retries&#x3D;xxx&amp;max_retries&#x3D;xxx*******。
        /// </summary>
        [SDKProperty("max_retries", IsQuery = true)]
        [JsonProperty("max_retries", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> MaxRetries { get; set; }

        /// <summary>
        /// 健康检查的管理状态。  取值： - true：表示开启健康检查，默认为true。 - false表示关闭健康检查。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 健康检查连续失败多少次后，将后端服务器的健康检查状态由ONLINE判定为OFFLINE。取值范围：1-10。  支持多值查询，查询条件格式：******max_retries_down&#x3D;xxx&amp;max_retries_down&#x3D;xxx******。
        /// </summary>
        [SDKProperty("max_retries_down", IsQuery = true)]
        [JsonProperty("max_retries_down", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> MaxRetriesDown { get; set; }

        /// <summary>
        /// 一次健康检查请求的超时时间。
        /// </summary>
        [SDKProperty("timeout", IsQuery = true)]
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 健康检查请求协议。  取值：TCP、UDP_CONNECT、HTTP、HTTPS。  支持多值查询，查询条件格式：*****type&#x3D;xxx&amp;type&#x3D;xxx*****。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// 期望响应状态码。  取值： - 单值：单个返回码，例如200。 - 列表：多个特定返回码，例如200，202。 - 区间：一个返回码区间，例如200-204。   默认值：200。  仅支持HTTP/HTTPS设置该字段，其他协议设置不会生效。  支持多值查询，查询条件格式：****expected_codes&#x3D;xxx&amp;expected_codes&#x3D;xxx****。
        /// </summary>
        [SDKProperty("expected_codes", IsQuery = true)]
        [JsonProperty("expected_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExpectedCodes { get; set; }

        /// <summary>
        /// 健康检查测试member健康时发送的http请求路径。默认为“/”。  使用说明：以“/”开头。当type为HTTP/HTTPS时生效。  支持多值查询，查询条件格式：***url_path&#x3D;xxx&amp;url_path&#x3D;xxx***。
        /// </summary>
        [SDKProperty("url_path", IsQuery = true)]
        [JsonProperty("url_path", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UrlPath { get; set; }

        /// <summary>
        /// HTTP请求方法。  取值：GET、HEAD、POST、PUT、DELETE、TRACE、OPTIONS、CONNECT、PATCH。  支持多值查询，查询条件格式：**http_method&#x3D;xxx&amp;http_method&#x3D;xxx**。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("http_method", IsQuery = true)]
        [JsonProperty("http_method", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HttpMethod { get; set; }

        /// <summary>
        /// 企业项目ID。不传时查询default企业项目\&quot;0\&quot;下的资源，鉴权按照default企业项目鉴权； 如果传值，则传已存在的企业项目ID或all_granted_eps（表示查询所有企业项目）进行查询。  支持多值查询，查询条件格式： *enterprise_project_id&#x3D;xxx&amp;enterprise_project_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHealthMonitorsRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  monitorPort: ").Append(MonitorPort).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  maxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  maxRetriesDown: ").Append(MaxRetriesDown).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  expectedCodes: ").Append(ExpectedCodes).Append("\n");
            sb.Append("  urlPath: ").Append(UrlPath).Append("\n");
            sb.Append("  httpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHealthMonitorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHealthMonitorsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.MonitorPort == input.MonitorPort ||
                    this.MonitorPort != null &&
                    input.MonitorPort != null &&
                    this.MonitorPort.SequenceEqual(input.MonitorPort)
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    this.DomainName != null &&
                    input.DomainName != null &&
                    this.DomainName.SequenceEqual(input.DomainName)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Delay == input.Delay ||
                    this.Delay != null &&
                    input.Delay != null &&
                    this.Delay.SequenceEqual(input.Delay)
                ) && 
                (
                    this.MaxRetries == input.MaxRetries ||
                    this.MaxRetries != null &&
                    input.MaxRetries != null &&
                    this.MaxRetries.SequenceEqual(input.MaxRetries)
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.MaxRetriesDown == input.MaxRetriesDown ||
                    this.MaxRetriesDown != null &&
                    input.MaxRetriesDown != null &&
                    this.MaxRetriesDown.SequenceEqual(input.MaxRetriesDown)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    input.Type != null &&
                    this.Type.SequenceEqual(input.Type)
                ) && 
                (
                    this.ExpectedCodes == input.ExpectedCodes ||
                    this.ExpectedCodes != null &&
                    input.ExpectedCodes != null &&
                    this.ExpectedCodes.SequenceEqual(input.ExpectedCodes)
                ) && 
                (
                    this.UrlPath == input.UrlPath ||
                    this.UrlPath != null &&
                    input.UrlPath != null &&
                    this.UrlPath.SequenceEqual(input.UrlPath)
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    this.HttpMethod != null &&
                    input.HttpMethod != null &&
                    this.HttpMethod.SequenceEqual(input.HttpMethod)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MonitorPort != null)
                    hashCode = hashCode * 59 + this.MonitorPort.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.MaxRetries != null)
                    hashCode = hashCode * 59 + this.MaxRetries.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.MaxRetriesDown != null)
                    hashCode = hashCode * 59 + this.MaxRetriesDown.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExpectedCodes != null)
                    hashCode = hashCode * 59 + this.ExpectedCodes.GetHashCode();
                if (this.UrlPath != null)
                    hashCode = hashCode * 59 + this.UrlPath.GetHashCode();
                if (this.HttpMethod != null)
                    hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}

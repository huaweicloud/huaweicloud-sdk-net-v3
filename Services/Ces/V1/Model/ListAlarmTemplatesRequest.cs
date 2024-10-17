using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAlarmTemplatesRequest 
    {

        /// <summary>
        /// 自定义告警模的ID，如：at1603330892378wkDm77y6B。
        /// </summary>
        [SDKProperty("alarmTemplateId", IsQuery = true)]
        [JsonProperty("alarmTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTemplateId { get; set; }

        /// <summary>
        /// 自定义告警模板选择的资源类型。即命名空间，如弹性云服务器的资源命名空间为：SYS.ECS；各服务命名空间可查看：“[服务命名空间](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 自定义告警模板选择的资源维度，如：弹性云服务器，则维度为instance_id，各资源的指标维度名称可查看：“[服务指标维度](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [SDKProperty("dname", IsQuery = true)]
        [JsonProperty("dname", NullValueHandling = NullValueHandling.Ignore)]
        public string Dname { get; set; }

        /// <summary>
        /// 分页起始值，类型为integer，默认值为0。
        /// </summary>
        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }

        /// <summary>
        /// 单次查询的条数限制，取值范围(0,100]，默认值为100， 用于限制结果数据条数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmTemplatesRequest {\n");
            sb.Append("  alarmTemplateId: ").Append(AlarmTemplateId).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dname: ").Append(Dname).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.AlarmTemplateId != input.AlarmTemplateId || (this.AlarmTemplateId != null && !this.AlarmTemplateId.Equals(input.AlarmTemplateId))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Dname != input.Dname || (this.Dname != null && !this.Dname.Equals(input.Dname))) return false;
            if (this.Start != input.Start || (this.Start != null && !this.Start.Equals(input.Start))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.AlarmTemplateId != null) hashCode = hashCode * 59 + this.AlarmTemplateId.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Dname != null) hashCode = hashCode * 59 + this.Dname.GetHashCode();
                if (this.Start != null) hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}

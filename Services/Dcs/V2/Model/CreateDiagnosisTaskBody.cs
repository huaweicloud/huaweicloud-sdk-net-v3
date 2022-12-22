using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 发起实例诊断请求体
    /// </summary>
    public class CreateDiagnosisTaskBody 
    {

        /// <summary>
        /// 诊断开始时间。UNIX时间戳，单位毫秒。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 诊断结束时间。UNIX时间戳，单位毫秒。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 诊断节点IP列表。默认诊断所有节点。 非读写分离实例查询方法如下：   - 方法一：参考[查看实例信息](https://support.huaweicloud.com/usermanual-dcs/dcs-ug-0312016.html)。   - 方法二：调用[查询指定实例](https://support.huaweicloud.com/api-dcs/ShowInstance.html)查询。  读写分离实例查询方法：调用[查询分片信息](https://support.huaweicloud.com/api-dcs/ListGroupReplicationInfo.html#ListGroupReplicationInfo__response_InstanceReplicationListInfo)。 
        /// </summary>
        [JsonProperty("node_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIpList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDiagnosisTaskBody {\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  nodeIpList: ").Append(NodeIpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDiagnosisTaskBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDiagnosisTaskBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.NodeIpList == input.NodeIpList ||
                    this.NodeIpList != null &&
                    input.NodeIpList != null &&
                    this.NodeIpList.SequenceEqual(input.NodeIpList)
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
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.NodeIpList != null)
                    hashCode = hashCode * 59 + this.NodeIpList.GetHashCode();
                return hashCode;
            }
        }
    }
}

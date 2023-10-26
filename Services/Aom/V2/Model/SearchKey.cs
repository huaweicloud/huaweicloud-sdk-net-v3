using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 日志过滤条件集合，不同日志来源所需字段不同。
    /// </summary>
    public class SearchKey 
    {

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("appName", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// CCE集群ID。
        /// </summary>
        [JsonProperty("clusterId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 日志所在虚拟机IP。
        /// </summary>
        [JsonProperty("hostIP", NullValueHandling = NullValueHandling.Ignore)]
        public string HostIP { get; set; }

        /// <summary>
        /// CCE容器集群的命名空间。
        /// </summary>
        [JsonProperty("nameSpace", NullValueHandling = NullValueHandling.Ignore)]
        public string NameSpace { get; set; }

        /// <summary>
        /// 日志文件名称。
        /// </summary>
        [JsonProperty("pathFile", NullValueHandling = NullValueHandling.Ignore)]
        public string PathFile { get; set; }

        /// <summary>
        /// 容器实例名称。
        /// </summary>
        [JsonProperty("podName", NullValueHandling = NullValueHandling.Ignore)]
        public string PodName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchKey {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  hostIP: ").Append(HostIP).Append("\n");
            sb.Append("  nameSpace: ").Append(NameSpace).Append("\n");
            sb.Append("  pathFile: ").Append(PathFile).Append("\n");
            sb.Append("  podName: ").Append(PodName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchKey);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.HostIP == input.HostIP ||
                    (this.HostIP != null &&
                    this.HostIP.Equals(input.HostIP))
                ) && 
                (
                    this.NameSpace == input.NameSpace ||
                    (this.NameSpace != null &&
                    this.NameSpace.Equals(input.NameSpace))
                ) && 
                (
                    this.PathFile == input.PathFile ||
                    (this.PathFile != null &&
                    this.PathFile.Equals(input.PathFile))
                ) && 
                (
                    this.PodName == input.PodName ||
                    (this.PodName != null &&
                    this.PodName.Equals(input.PodName))
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
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.HostIP != null)
                    hashCode = hashCode * 59 + this.HostIP.GetHashCode();
                if (this.NameSpace != null)
                    hashCode = hashCode * 59 + this.NameSpace.GetHashCode();
                if (this.PathFile != null)
                    hashCode = hashCode * 59 + this.PathFile.GetHashCode();
                if (this.PodName != null)
                    hashCode = hashCode * 59 + this.PodName.GetHashCode();
                return hashCode;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class DeleteServersRequestBody 
    {

        /// <summary>
        /// 配置删除云服务器是否删除云服务器绑定的弹性IP。如果选择不删除，则系统仅做解绑定操作，保留弹性IP资源。 取值为true或false，默认为false。   - true：删除云服务器时会同时删除绑定在云服务器上的弹性IP。  - false：删除云服务器时，仅解绑定在云服务器上的弹性IP，不删除弹性IP
        /// </summary>
        [JsonProperty("delete_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletePublicip { get; set; }

        /// <summary>
        /// 配置删除云服务器是否删除云服务器对应的数据盘，如果选择不删除，则系统仅做解绑定操作，保留云磁盘资源。 取值为false或true，默认为false。  - true：删除云服务器时会同时删除挂载在云服务器上的数据盘。 - false：删除云服务器时，仅卸载云服务器上挂载的数据盘，不删除该数据盘。
        /// </summary>
        [JsonProperty("delete_volume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteVolume { get; set; }

        /// <summary>
        /// 所需要删除的云服务器列表。
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerId> Servers { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteServersRequestBody {\n");
            sb.Append("  deletePublicip: ").Append(DeletePublicip).Append("\n");
            sb.Append("  deleteVolume: ").Append(DeleteVolume).Append("\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteServersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteServersRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeletePublicip == input.DeletePublicip ||
                    (this.DeletePublicip != null &&
                    this.DeletePublicip.Equals(input.DeletePublicip))
                ) && 
                (
                    this.DeleteVolume == input.DeleteVolume ||
                    (this.DeleteVolume != null &&
                    this.DeleteVolume.Equals(input.DeleteVolume))
                ) && 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    input.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
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
                if (this.DeletePublicip != null)
                    hashCode = hashCode * 59 + this.DeletePublicip.GetHashCode();
                if (this.DeleteVolume != null)
                    hashCode = hashCode * 59 + this.DeleteVolume.GetHashCode();
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
                return hashCode;
            }
        }
    }
}

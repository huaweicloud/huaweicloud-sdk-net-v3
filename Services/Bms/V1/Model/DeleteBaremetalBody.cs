using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class DeleteBaremetalBody 
    {

        /// <summary>
        /// 所需要删除的裸金属服务器列表。
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServersList> Servers { get; set; }

        /// <summary>
        /// 删除裸金属服务器时是否删除裸金属服务器绑定的弹性公网IP。如果选择不删除，则系统仅做解绑定操作，保留弹性公网IP资源。 取值为true或false，默认为false。  true：删除裸金属服务器时会同时删除绑定在裸金属服务器上的弹性公网IP。 false：删除裸金属服务器时，仅解绑定在裸金属服务器上的弹性公网IP，不删除弹性公网IP。
        /// </summary>
        [JsonProperty("delete_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletePublicip { get; set; }

        /// <summary>
        /// 删除裸金属服务器时是否删除裸金属服务器对应的数据盘。如果选择不删除，则系统仅做解绑定操作，保留数据盘资源。 取值为false或true，默认为false。  true：删除裸金属服务器时会同时删除挂载在裸金属服务器上的数据盘。 false：删除裸金属服务器时，仅卸载裸金属服务器上挂载的数据盘，不删除该数据盘。
        /// </summary>
        [JsonProperty("delete_volume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteVolume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteBaremetalBody {\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("  deletePublicip: ").Append(DeletePublicip).Append("\n");
            sb.Append("  deleteVolume: ").Append(DeleteVolume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteBaremetalBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteBaremetalBody input)
        {
            if (input == null) return false;
            if (this.Servers != input.Servers || (this.Servers != null && input.Servers != null && !this.Servers.SequenceEqual(input.Servers))) return false;
            if (this.DeletePublicip != input.DeletePublicip || (this.DeletePublicip != null && !this.DeletePublicip.Equals(input.DeletePublicip))) return false;
            if (this.DeleteVolume != input.DeleteVolume || (this.DeleteVolume != null && !this.DeleteVolume.Equals(input.DeleteVolume))) return false;

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
                if (this.Servers != null) hashCode = hashCode * 59 + this.Servers.GetHashCode();
                if (this.DeletePublicip != null) hashCode = hashCode * 59 + this.DeletePublicip.GetHashCode();
                if (this.DeleteVolume != null) hashCode = hashCode * 59 + this.DeleteVolume.GetHashCode();
                return hashCode;
            }
        }
    }
}

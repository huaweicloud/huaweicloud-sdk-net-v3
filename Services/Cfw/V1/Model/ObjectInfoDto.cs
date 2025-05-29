using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ObjectInfoDto 
    {

        /// <summary>
        /// 成员描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 防火墙ID，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取
        /// </summary>
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 成员id，地址组成员id，可通过[查询地址组成员接口](ListAddressItems.xml)查询获得，通过返回值中的data.records.item_id（.表示各对象之间层级的区分）获得。服务组成员id，可通过[查询服务成员列表接口](ListServiceItems.xml)查询获得，通过返回值中的data.records.item_id（.表示各对象之间层级的区分）获得。域名id可通过[获取域名组下域名列表接口](ListDomains.xml)查询获得，通过返回值中的data.records.domain_address_id（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        /// 组id，地址组id，可通过[查询地址组列表接口](ListAddressSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。服务组id，可通过[获取服务组列表接口](ListServiceSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。域名组id，可通过[查询域名组列表接口](ListDomainSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }

        /// <summary>
        /// 组类型，包含：地址组ADDR_SET，服务组SERV_SET，域名组DOMAIN_SET，URL组URL_SET
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectInfoDto {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  itemId: ").Append(ItemId).Append("\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectInfoDto input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.ItemId != input.ItemId || (this.ItemId != null && !this.ItemId.Equals(input.ItemId))) return false;
            if (this.SetId != input.SetId || (this.SetId != null && !this.SetId.Equals(input.SetId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.ItemId != null) hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.SetId != null) hashCode = hashCode * 59 + this.SetId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}

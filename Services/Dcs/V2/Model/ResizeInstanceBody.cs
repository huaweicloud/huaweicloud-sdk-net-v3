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
    /// 
    /// </summary>
    public class ResizeInstanceBody 
    {
        /// <summary>
        /// 变更类型，Redis 4.0或者5.0主备实例进行副本数变更时必选。 - createReplication: 添加副本 - deleteReplication: 删除副本 
        /// </summary>
        /// <value>变更类型，Redis 4.0或者5.0主备实例进行副本数变更时必选。 - createReplication: 添加副本 - deleteReplication: 删除副本 </value>
        [JsonConverter(typeof(EnumClassConverter<ChangeTypeEnum>))]
        public class ChangeTypeEnum
        {
            /// <summary>
            /// Enum CREATEREPLICATION for value: createReplication
            /// </summary>
            public static readonly ChangeTypeEnum CREATEREPLICATION = new ChangeTypeEnum("createReplication");

            /// <summary>
            /// Enum DELETEREPLICATION for value: deleteReplication
            /// </summary>
            public static readonly ChangeTypeEnum DELETEREPLICATION = new ChangeTypeEnum("deleteReplication");

            private static readonly Dictionary<string, ChangeTypeEnum> StaticFields =
            new Dictionary<string, ChangeTypeEnum>()
            {
                { "createReplication", CREATEREPLICATION },
                { "deleteReplication", DELETEREPLICATION },
            };

            private string Value;

            public ChangeTypeEnum(string value)
            {
                Value = value;
            }

            public static ChangeTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ChangeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChangeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ChangeTypeEnum a, ChangeTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ChangeTypeEnum a, ChangeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 产品规格编码。具体查询方法如下：  - 方法一：查询产品介绍中的[实例规格](https://support.huaweicloud.com/productdesc-dcs/dcs-pd-0522002.html) - 方法二：登录分布式缓存的控制台界面，点击购买缓存实例，查找对应的实例规格名称 - 方法三：调用[查询产品规格](https://support.huaweicloud.com/api-dcs/ListFlavors.html)接口查询。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 新的缓存实例规格，新的规格必须大于扩容前的规格，单位：GB。 取值包括：4，8，16，32，64 取值必须是当前产品支持的实例规格，请以实际为准。 
        /// </summary>
        [JsonProperty("new_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCapacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bss_param", NullValueHandling = NullValueHandling.Ignore)]
        public BssParamEntity BssParam { get; set; }

        /// <summary>
        /// 需要保留的节点ip。cluster集群缩容时需要填写，不填写时系统将随机删除多余的分片
        /// </summary>
        [JsonProperty("reserved_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReservedIp { get; set; }

        /// <summary>
        /// 变更类型，Redis 4.0或者5.0主备实例进行副本数变更时必选。 - createReplication: 添加副本 - deleteReplication: 删除副本 
        /// </summary>
        [JsonProperty("change_type", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeTypeEnum ChangeType { get; set; }
        /// <summary>
        /// Redis 4.0或者5.0主备实例进行添加副本时必选，指定每个副本所在的可用区Code，使用前需要先确认该可用区资源是否售罄。  具体查询方法，请参考[查询可用区信息](https://support.huaweicloud.com/api-dcs/ListAvailableZones.html) 
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// Redis 4.0或者5.0主备实例进行删除副本时必选，指定需要删除的节点ID，目前仅支持一次删除一个副本。  节点ID查询方法，请参考[查询分片信息](https://support.huaweicloud.com/api-dcs/ListGroupReplicationInfo.html) 
        /// </summary>
        [JsonProperty("node_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeList { get; set; }

        /// <summary>
        /// 是否立即变更。默认值为true。 - true: 立即变更 - false: 可维护时间窗内进行变更 
        /// </summary>
        [JsonProperty("execute_immediately", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecuteImmediately { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeInstanceBody {\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  newCapacity: ").Append(NewCapacity).Append("\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("  reservedIp: ").Append(ReservedIp).Append("\n");
            sb.Append("  changeType: ").Append(ChangeType).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("  executeImmediately: ").Append(ExecuteImmediately).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeInstanceBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeInstanceBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.NewCapacity == input.NewCapacity ||
                    (this.NewCapacity != null &&
                    this.NewCapacity.Equals(input.NewCapacity))
                ) && 
                (
                    this.BssParam == input.BssParam ||
                    (this.BssParam != null &&
                    this.BssParam.Equals(input.BssParam))
                ) && 
                (
                    this.ReservedIp == input.ReservedIp ||
                    this.ReservedIp != null &&
                    input.ReservedIp != null &&
                    this.ReservedIp.SequenceEqual(input.ReservedIp)
                ) && 
                (
                    this.ChangeType == input.ChangeType ||
                    (this.ChangeType != null &&
                    this.ChangeType.Equals(input.ChangeType))
                ) && 
                (
                    this.AvailableZones == input.AvailableZones ||
                    this.AvailableZones != null &&
                    input.AvailableZones != null &&
                    this.AvailableZones.SequenceEqual(input.AvailableZones)
                ) && 
                (
                    this.NodeList == input.NodeList ||
                    this.NodeList != null &&
                    input.NodeList != null &&
                    this.NodeList.SequenceEqual(input.NodeList)
                ) && 
                (
                    this.ExecuteImmediately == input.ExecuteImmediately ||
                    (this.ExecuteImmediately != null &&
                    this.ExecuteImmediately.Equals(input.ExecuteImmediately))
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
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.NewCapacity != null)
                    hashCode = hashCode * 59 + this.NewCapacity.GetHashCode();
                if (this.BssParam != null)
                    hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                if (this.ReservedIp != null)
                    hashCode = hashCode * 59 + this.ReservedIp.GetHashCode();
                if (this.ChangeType != null)
                    hashCode = hashCode * 59 + this.ChangeType.GetHashCode();
                if (this.AvailableZones != null)
                    hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.NodeList != null)
                    hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                if (this.ExecuteImmediately != null)
                    hashCode = hashCode * 59 + this.ExecuteImmediately.GetHashCode();
                return hashCode;
            }
        }
    }
}

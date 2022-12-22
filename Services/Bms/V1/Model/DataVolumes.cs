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
    /// data_volumes字段数据结构说明
    /// </summary>
    public class DataVolumes 
    {
        /// <summary>
        /// 裸金属服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。SATA：普通IO磁盘类型SAS：高IO磁盘类型SSD：超高IO磁盘类型约束：在专属云中申请裸金属服务器时，须使用专属企业存储，此时该字段前缀必须是DESS_ 。枚举值如下：DESS_SAS_ISCSI：普通I/O企业存储DESS_SAS_FC：普通I/O企业存储（低延时）DESS_MIX_ISCSI：高I/O企业存储DESS_MIX_FC：高I/O企业存储（低延时）DESS_SSD_ISCSI：超高I/O企业存储DESS_SSD_FC：超高I/O企业存储（低延时）所有用户，包年包月场景下，不能挂载DESS卷。 说明：企业存储支持的存储类型说明可以从管理控制台或参考《专属企业存储服务用户指南》的“申请专属企业存储”“申请专属企业存储”章节获取。
        /// </summary>
        /// <value>裸金属服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。SATA：普通IO磁盘类型SAS：高IO磁盘类型SSD：超高IO磁盘类型约束：在专属云中申请裸金属服务器时，须使用专属企业存储，此时该字段前缀必须是DESS_ 。枚举值如下：DESS_SAS_ISCSI：普通I/O企业存储DESS_SAS_FC：普通I/O企业存储（低延时）DESS_MIX_ISCSI：高I/O企业存储DESS_MIX_FC：高I/O企业存储（低延时）DESS_SSD_ISCSI：超高I/O企业存储DESS_SSD_FC：超高I/O企业存储（低延时）所有用户，包年包月场景下，不能挂载DESS卷。 说明：企业存储支持的存储类型说明可以从管理控制台或参考《专属企业存储服务用户指南》的“申请专属企业存储”“申请专属企业存储”章节获取。</value>
        [JsonConverter(typeof(EnumClassConverter<VolumetypeEnum>))]
        public class VolumetypeEnum
        {
            /// <summary>
            /// Enum SATA for value: SATA
            /// </summary>
            public static readonly VolumetypeEnum SATA = new VolumetypeEnum("SATA");

            /// <summary>
            /// Enum SAS for value: SAS
            /// </summary>
            public static readonly VolumetypeEnum SAS = new VolumetypeEnum("SAS");

            /// <summary>
            /// Enum SSD for value: SSD
            /// </summary>
            public static readonly VolumetypeEnum SSD = new VolumetypeEnum("SSD");

            private static readonly Dictionary<string, VolumetypeEnum> StaticFields =
            new Dictionary<string, VolumetypeEnum>()
            {
                { "SATA", SATA },
                { "SAS", SAS },
                { "SSD", SSD },
            };

            private string _value;

            public VolumetypeEnum()
            {

            }

            public VolumetypeEnum(string value)
            {
                _value = value;
            }

            public static VolumetypeEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as VolumetypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VolumetypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VolumetypeEnum a, VolumetypeEnum b)
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

            public static bool operator !=(VolumetypeEnum a, VolumetypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 裸金属服务器数据盘对应的磁盘存储类型。磁盘存储类型枚举值：DSS（专属分布式存储）。 说明：使用专属分布式存储时需要该字段。存储池类型可以从管理控制台或者参考《专属分布式存储API参考》的“获取专属分布式存储池详情列表”章节获取。
        /// </summary>
        /// <value>裸金属服务器数据盘对应的磁盘存储类型。磁盘存储类型枚举值：DSS（专属分布式存储）。 说明：使用专属分布式存储时需要该字段。存储池类型可以从管理控制台或者参考《专属分布式存储API参考》的“获取专属分布式存储池详情列表”章节获取。</value>
        [JsonConverter(typeof(EnumClassConverter<ClusterTypeEnum>))]
        public class ClusterTypeEnum
        {
            /// <summary>
            /// Enum DSS for value: DSS
            /// </summary>
            public static readonly ClusterTypeEnum DSS = new ClusterTypeEnum("DSS");

            private static readonly Dictionary<string, ClusterTypeEnum> StaticFields =
            new Dictionary<string, ClusterTypeEnum>()
            {
                { "DSS", DSS },
            };

            private string _value;

            public ClusterTypeEnum()
            {

            }

            public ClusterTypeEnum(string value)
            {
                _value = value;
            }

            public static ClusterTypeEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as ClusterTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ClusterTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ClusterTypeEnum a, ClusterTypeEnum b)
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

            public static bool operator !=(ClusterTypeEnum a, ClusterTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 裸金属服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。SATA：普通IO磁盘类型SAS：高IO磁盘类型SSD：超高IO磁盘类型约束：在专属云中申请裸金属服务器时，须使用专属企业存储，此时该字段前缀必须是DESS_ 。枚举值如下：DESS_SAS_ISCSI：普通I/O企业存储DESS_SAS_FC：普通I/O企业存储（低延时）DESS_MIX_ISCSI：高I/O企业存储DESS_MIX_FC：高I/O企业存储（低延时）DESS_SSD_ISCSI：超高I/O企业存储DESS_SSD_FC：超高I/O企业存储（低延时）所有用户，包年包月场景下，不能挂载DESS卷。 说明：企业存储支持的存储类型说明可以从管理控制台或参考《专属企业存储服务用户指南》的“申请专属企业存储”“申请专属企业存储”章节获取。
        /// </summary>
        [JsonProperty("volumetype", NullValueHandling = NullValueHandling.Ignore)]
        public VolumetypeEnum Volumetype { get; set; }
        /// <summary>
        /// 数据盘大小，容量单位为GB，输入大小范围为[10-32768]。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 是否为共享磁盘。true为共享盘，false为普通云硬盘
        /// </summary>
        [JsonProperty("shareable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shareable { get; set; }

        /// <summary>
        /// 裸金属服务器数据盘对应的存储池ID。 说明：使用专属分布式存储时需要该字段。存储池ID可以从管理控制台或者参考《专属分布式存储API参考》的“获取专属分布式存储池详情列表”章节获取。
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ClusterId { get; set; }

        /// <summary>
        /// 裸金属服务器数据盘对应的磁盘存储类型。磁盘存储类型枚举值：DSS（专属分布式存储）。 说明：使用专属分布式存储时需要该字段。存储池类型可以从管理控制台或者参考《专属分布式存储API参考》的“获取专属分布式存储池详情列表”章节获取。
        /// </summary>
        [JsonProperty("cluster_type", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterTypeEnum ClusterType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataVolumes {\n");
            sb.Append("  volumetype: ").Append(Volumetype).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  shareable: ").Append(Shareable).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataVolumes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataVolumes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Volumetype == input.Volumetype ||
                    (this.Volumetype != null &&
                    this.Volumetype.Equals(input.Volumetype))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Shareable == input.Shareable ||
                    (this.Shareable != null &&
                    this.Shareable.Equals(input.Shareable))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterType == input.ClusterType ||
                    (this.ClusterType != null &&
                    this.ClusterType.Equals(input.ClusterType))
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
                if (this.Volumetype != null)
                    hashCode = hashCode * 59 + this.Volumetype.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Shareable != null)
                    hashCode = hashCode * 59 + this.Shareable.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterType != null)
                    hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                return hashCode;
            }
        }
    }
}

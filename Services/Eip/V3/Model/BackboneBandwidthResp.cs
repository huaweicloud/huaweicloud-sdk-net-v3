using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 骨干带宽对象
    /// </summary>
    public class BackboneBandwidthResp 
    {
        /// <summary>
        /// 描述网络等级，从高到低分为铂金、金、银、铜
        /// </summary>
        /// <value>描述网络等级，从高到低分为铂金、金、银、铜</value>
        [JsonConverter(typeof(EnumClassConverter<SlaLevelEnum>))]
        public class SlaLevelEnum
        {
            /// <summary>
            /// Enum PT for value: Pt
            /// </summary>
            public static readonly SlaLevelEnum PT = new SlaLevelEnum("Pt");

            /// <summary>
            /// Enum AU for value: Au
            /// </summary>
            public static readonly SlaLevelEnum AU = new SlaLevelEnum("Au");

            /// <summary>
            /// Enum AG for value: Ag
            /// </summary>
            public static readonly SlaLevelEnum AG = new SlaLevelEnum("Ag");

            /// <summary>
            /// Enum CU for value: Cu
            /// </summary>
            public static readonly SlaLevelEnum CU = new SlaLevelEnum("Cu");

            private static readonly Dictionary<string, SlaLevelEnum> StaticFields =
            new Dictionary<string, SlaLevelEnum>()
            {
                { "Pt", PT },
                { "Au", AU },
                { "Ag", AG },
                { "Cu", CU },
            };

            private string _value;

            public SlaLevelEnum()
            {

            }

            public SlaLevelEnum(string value)
            {
                _value = value;
            }

            public static SlaLevelEnum FromValue(string value)
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

                if (this.Equals(obj as SlaLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SlaLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SlaLevelEnum a, SlaLevelEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SlaLevelEnum a, SlaLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 骨干带宽的uuid
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 骨干带宽的状态
        /// </summary>
        [JsonProperty("admin_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminStatus { get; set; }

        /// <summary>
        /// 骨干带宽的大小
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 骨干带宽的short_id
        /// </summary>
        [JsonProperty("short_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortId { get; set; }

        /// <summary>
        /// 描述网络等级，从高到低分为铂金、金、银、铜
        /// </summary>
        [JsonProperty("sla_level", NullValueHandling = NullValueHandling.Ignore)]
        public SlaLevelEnum SlaLevel { get; set; }
        /// <summary>
        /// 线路质量金银铜对应的DSCP值
        /// </summary>
        [JsonProperty("dscp", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dscp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackboneBandwidthResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  adminStatus: ").Append(AdminStatus).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  shortId: ").Append(ShortId).Append("\n");
            sb.Append("  slaLevel: ").Append(SlaLevel).Append("\n");
            sb.Append("  dscp: ").Append(Dscp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackboneBandwidthResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackboneBandwidthResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AdminStatus != input.AdminStatus || (this.AdminStatus != null && !this.AdminStatus.Equals(input.AdminStatus))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.ShortId != input.ShortId || (this.ShortId != null && !this.ShortId.Equals(input.ShortId))) return false;
            if (this.SlaLevel != input.SlaLevel) return false;
            if (this.Dscp != input.Dscp || (this.Dscp != null && !this.Dscp.Equals(input.Dscp))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AdminStatus != null) hashCode = hashCode * 59 + this.AdminStatus.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ShortId != null) hashCode = hashCode * 59 + this.ShortId.GetHashCode();
                hashCode = hashCode * 59 + this.SlaLevel.GetHashCode();
                if (this.Dscp != null) hashCode = hashCode * 59 + this.Dscp.GetHashCode();
                return hashCode;
            }
        }
    }
}

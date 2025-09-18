using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListGlobalConnectionBandwidthLineLevelsRequest 
    {
        /// <summary>
        /// Defines levels
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<LevelsEnum>))]
        public class LevelsEnum
        {
            /// <summary>
            /// Enum PT for value: Pt
            /// </summary>
            public static readonly LevelsEnum PT = new LevelsEnum("Pt");

            /// <summary>
            /// Enum AG for value: Ag
            /// </summary>
            public static readonly LevelsEnum AG = new LevelsEnum("Ag");

            private static readonly Dictionary<string, LevelsEnum> StaticFields =
            new Dictionary<string, LevelsEnum>()
            {
                { "Pt", PT },
                { "Ag", AG },
            };

            private string _value;

            public LevelsEnum()
            {

            }

            public LevelsEnum(string value)
            {
                _value = value;
            }

            public static LevelsEnum FromValue(string value)
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

                if (this.Equals(obj as LevelsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LevelsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LevelsEnum a, LevelsEnum b)
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

            public static bool operator !=(LevelsEnum a, LevelsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 每页返回的个数。 取值范围：1~2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 翻页信息，从上次API调用返回的翻页数据中获取，可填写前一页marker或者后一页marker，填入前一页previous_marker就向前翻页，后一页next_marker就向后翻页。 翻页过程中，查询条件不能修改，包括过滤条件、排序条件、limit。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 根据ID查询，可查询多个ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 线路规格本端接入点编码信息。
        /// </summary>
        [SDKProperty("local_area", IsQuery = true)]
        [JsonProperty("local_area", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalArea { get; set; }

        /// <summary>
        /// 线路规格远端接入点编码信息。
        /// </summary>
        [SDKProperty("remote_area", IsQuery = true)]
        [JsonProperty("remote_area", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteArea { get; set; }

        /// <summary>
        /// 带宽等级信息： - Pt: 铂金 - Ag: 银
        /// </summary>
        [SDKProperty("levels", IsQuery = true)]
        [JsonProperty("levels", NullValueHandling = NullValueHandling.Ignore)]
        public List<LevelsEnum> Levels { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGlobalConnectionBandwidthLineLevelsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  localArea: ").Append(LocalArea).Append("\n");
            sb.Append("  remoteArea: ").Append(RemoteArea).Append("\n");
            sb.Append("  levels: ").Append(Levels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGlobalConnectionBandwidthLineLevelsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGlobalConnectionBandwidthLineLevelsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.LocalArea != input.LocalArea || (this.LocalArea != null && !this.LocalArea.Equals(input.LocalArea))) return false;
            if (this.RemoteArea != input.RemoteArea || (this.RemoteArea != null && !this.RemoteArea.Equals(input.RemoteArea))) return false;
            if (this.Levels != input.Levels || (this.Levels != null && input.Levels != null && !this.Levels.SequenceEqual(input.Levels))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LocalArea != null) hashCode = hashCode * 59 + this.LocalArea.GetHashCode();
                if (this.RemoteArea != null) hashCode = hashCode * 59 + this.RemoteArea.GetHashCode();
                hashCode = hashCode * 59 + this.Levels.GetHashCode();
                return hashCode;
            }
        }
    }
}

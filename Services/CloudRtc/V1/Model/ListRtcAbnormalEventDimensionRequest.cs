using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRtcAbnormalEventDimensionRequest 
    {
        /// <summary>
        /// 分组类型，支持同时指定两种类型 - abnormal_type：异常类型 - abnormal_factor：异常因素 
        /// </summary>
        /// <value>分组类型，支持同时指定两种类型 - abnormal_type：异常类型 - abnormal_factor：异常因素 </value>
        [JsonConverter(typeof(EnumClassConverter<DimensionEnum>))]
        public class DimensionEnum
        {
            /// <summary>
            /// Enum ABNORMAL_TYPE for value: abnormal_type
            /// </summary>
            public static readonly DimensionEnum ABNORMAL_TYPE = new DimensionEnum("abnormal_type");

            /// <summary>
            /// Enum ABNORMAL_FACTOR for value: abnormal_factor
            /// </summary>
            public static readonly DimensionEnum ABNORMAL_FACTOR = new DimensionEnum("abnormal_factor");

            private static readonly Dictionary<string, DimensionEnum> StaticFields =
            new Dictionary<string, DimensionEnum>()
            {
                { "abnormal_type", ABNORMAL_TYPE },
                { "abnormal_factor", ABNORMAL_FACTOR },
            };

            private string _value;

            public DimensionEnum()
            {

            }

            public DimensionEnum(string value)
            {
                _value = value;
            }

            public static DimensionEnum FromValue(string value)
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

                if (this.Equals(obj as DimensionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DimensionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DimensionEnum a, DimensionEnum b)
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

            public static bool operator !=(DimensionEnum a, DimensionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用ID 
        /// </summary>
        [SDKProperty("app", IsQuery = true)]
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 房间ID 
        /// </summary>
        [SDKProperty("room_id", IsQuery = true)]
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 分组类型，支持同时指定两种类型 - abnormal_type：异常类型 - abnormal_factor：异常因素 
        /// </summary>
        [SDKProperty("dimension", IsQuery = true)]
        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public DimensionEnum Dimension { get; set; }
        /// <summary>
        /// 查询起始时间。UTC时间，格式：YYYY-MM-DDThh:mm:ssZ，如2020-04-23T06:00:00Z，不填写则默认读取过去1小时数据数据。 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询结束时间。UTC时间，格式：YYYY-MM-DDThh:mm:ssZ，如2020-04-23T07:00:00Z，不填写则默认为当前时间。 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRtcAbnormalEventDimensionRequest {\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  dimension: ").Append(Dimension).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcAbnormalEventDimensionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcAbnormalEventDimensionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.RoomId == input.RoomId ||
                    (this.RoomId != null &&
                    this.RoomId.Equals(input.RoomId))
                ) && 
                (
                    this.Dimension == input.Dimension ||
                    (this.Dimension != null &&
                    this.Dimension.Equals(input.Dimension))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.RoomId != null)
                    hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.Dimension != null)
                    hashCode = hashCode * 59 + this.Dimension.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}

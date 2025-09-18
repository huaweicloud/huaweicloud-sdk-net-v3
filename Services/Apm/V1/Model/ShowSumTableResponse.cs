using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSumTableResponse : SdkResponse
    {
        /// <summary>
        /// 表格的方向，H：默认，表头横向，V：表头纵向。
        /// </summary>
        /// <value>表格的方向，H：默认，表头横向，V：表头纵向。</value>
        [JsonConverter(typeof(EnumClassConverter<TableDirectionEnum>))]
        public class TableDirectionEnum
        {
            /// <summary>
            /// Enum H for value: H
            /// </summary>
            public static readonly TableDirectionEnum H = new TableDirectionEnum("H");

            /// <summary>
            /// Enum V for value: V
            /// </summary>
            public static readonly TableDirectionEnum V = new TableDirectionEnum("V");

            private static readonly Dictionary<string, TableDirectionEnum> StaticFields =
            new Dictionary<string, TableDirectionEnum>()
            {
                { "H", H },
                { "V", V },
            };

            private string _value;

            public TableDirectionEnum()
            {

            }

            public TableDirectionEnum(string value)
            {
                _value = value;
            }

            public static TableDirectionEnum FromValue(string value)
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

                if (this.Equals(obj as TableDirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TableDirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TableDirectionEnum a, TableDirectionEnum b)
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

            public static bool operator !=(TableDirectionEnum a, TableDirectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 结果的ID信息，分页查询的时候带过来。
        /// </summary>
        [JsonProperty("result_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultId { get; set; }

        /// <summary>
        /// 数据行列表。
        /// </summary>
        [JsonProperty("row_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FrontRow> RowList { get; set; }

        /// <summary>
        /// 最近一笔数据的时间。
        /// </summary>
        [JsonProperty("latest_data_Time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LatestDataTime { get; set; }

        /// <summary>
        /// 表格的方向，H：默认，表头横向，V：表头纵向。
        /// </summary>
        [JsonProperty("table_direction", NullValueHandling = NullValueHandling.Ignore)]
        public TableDirectionEnum TableDirection { get; set; }
        /// <summary>
        /// 实际开始的时间。
        /// </summary>
        [JsonProperty("real_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RealStartTime { get; set; }

        /// <summary>
        /// 实际结束的时间。
        /// </summary>
        [JsonProperty("real_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RealEndTime { get; set; }

        /// <summary>
        /// 提示信息。
        /// </summary>
        [JsonProperty("notice_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticeMsg { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSumTableResponse {\n");
            sb.Append("  resultId: ").Append(ResultId).Append("\n");
            sb.Append("  rowList: ").Append(RowList).Append("\n");
            sb.Append("  latestDataTime: ").Append(LatestDataTime).Append("\n");
            sb.Append("  tableDirection: ").Append(TableDirection).Append("\n");
            sb.Append("  realStartTime: ").Append(RealStartTime).Append("\n");
            sb.Append("  realEndTime: ").Append(RealEndTime).Append("\n");
            sb.Append("  noticeMsg: ").Append(NoticeMsg).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSumTableResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSumTableResponse input)
        {
            if (input == null) return false;
            if (this.ResultId != input.ResultId || (this.ResultId != null && !this.ResultId.Equals(input.ResultId))) return false;
            if (this.RowList != input.RowList || (this.RowList != null && input.RowList != null && !this.RowList.SequenceEqual(input.RowList))) return false;
            if (this.LatestDataTime != input.LatestDataTime || (this.LatestDataTime != null && !this.LatestDataTime.Equals(input.LatestDataTime))) return false;
            if (this.TableDirection != input.TableDirection) return false;
            if (this.RealStartTime != input.RealStartTime || (this.RealStartTime != null && !this.RealStartTime.Equals(input.RealStartTime))) return false;
            if (this.RealEndTime != input.RealEndTime || (this.RealEndTime != null && !this.RealEndTime.Equals(input.RealEndTime))) return false;
            if (this.NoticeMsg != input.NoticeMsg || (this.NoticeMsg != null && !this.NoticeMsg.Equals(input.NoticeMsg))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.ResultId != null) hashCode = hashCode * 59 + this.ResultId.GetHashCode();
                if (this.RowList != null) hashCode = hashCode * 59 + this.RowList.GetHashCode();
                if (this.LatestDataTime != null) hashCode = hashCode * 59 + this.LatestDataTime.GetHashCode();
                hashCode = hashCode * 59 + this.TableDirection.GetHashCode();
                if (this.RealStartTime != null) hashCode = hashCode * 59 + this.RealStartTime.GetHashCode();
                if (this.RealEndTime != null) hashCode = hashCode * 59 + this.RealEndTime.GetHashCode();
                if (this.NoticeMsg != null) hashCode = hashCode * 59 + this.NoticeMsg.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}

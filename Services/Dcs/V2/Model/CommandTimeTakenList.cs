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
    /// 命令耗时统计列表
    /// </summary>
    public class CommandTimeTakenList 
    {
        /// <summary>
        /// 命令耗时统计结果
        /// </summary>
        /// <value>命令耗时统计结果</value>
        [JsonConverter(typeof(EnumClassConverter<ResultEnum>))]
        public class ResultEnum
        {
            /// <summary>
            /// Enum SUCCEED for value: succeed
            /// </summary>
            public static readonly ResultEnum SUCCEED = new ResultEnum("succeed");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly ResultEnum FAILED = new ResultEnum("failed");

            private static readonly Dictionary<string, ResultEnum> StaticFields =
            new Dictionary<string, ResultEnum>()
            {
                { "succeed", SUCCEED },
                { "failed", FAILED },
            };

            private string _value;

            public ResultEnum()
            {

            }

            public ResultEnum(string value)
            {
                _value = value;
            }

            public static ResultEnum FromValue(string value)
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

                if (this.Equals(obj as ResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResultEnum a, ResultEnum b)
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

            public static bool operator !=(ResultEnum a, ResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 执行命令的总次数
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 执行命令的总耗时
        /// </summary>
        [JsonProperty("total_usec_sum", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalUsecSum { get; set; }

        /// <summary>
        /// 命令耗时统计结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// 命令耗时统计
        /// </summary>
        [JsonProperty("command_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommandTimeTaken> CommandList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommandTimeTakenList {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  totalUsecSum: ").Append(TotalUsecSum).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  commandList: ").Append(CommandList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommandTimeTakenList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommandTimeTakenList input)
        {
            if (input == null) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.TotalUsecSum != input.TotalUsecSum || (this.TotalUsecSum != null && !this.TotalUsecSum.Equals(input.TotalUsecSum))) return false;
            if (this.Result != input.Result) return false;
            if (this.CommandList != input.CommandList || (this.CommandList != null && input.CommandList != null && !this.CommandList.SequenceEqual(input.CommandList))) return false;

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
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.TotalUsecSum != null) hashCode = hashCode * 59 + this.TotalUsecSum.GetHashCode();
                hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.CommandList != null) hashCode = hashCode * 59 + this.CommandList.GetHashCode();
                return hashCode;
            }
        }
    }
}

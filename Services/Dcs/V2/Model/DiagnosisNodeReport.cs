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
    /// 节点诊断报告
    /// </summary>
    public class DiagnosisNodeReport 
    {
        /// <summary>
        /// 节点角色
        /// </summary>
        /// <value>节点角色</value>
        [JsonConverter(typeof(EnumClassConverter<RoleEnum>))]
        public class RoleEnum
        {
            /// <summary>
            /// Enum MASTER for value: master
            /// </summary>
            public static readonly RoleEnum MASTER = new RoleEnum("master");

            /// <summary>
            /// Enum SLAVE for value: slave
            /// </summary>
            public static readonly RoleEnum SLAVE = new RoleEnum("slave");

            private static readonly Dictionary<string, RoleEnum> StaticFields =
            new Dictionary<string, RoleEnum>()
            {
                { "master", MASTER },
                { "slave", SLAVE },
            };

            private string Value;

            public RoleEnum(string value)
            {
                Value = value;
            }

            public static RoleEnum FromValue(string value)
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

                if (this.Equals(obj as RoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(RoleEnum a, RoleEnum b)
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

            public static bool operator !=(RoleEnum a, RoleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 节点IP。例如：192.168.0.234:6379
        /// </summary>
        [JsonProperty("node_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeIp { get; set; }

        /// <summary>
        /// 节点所在可用区Code
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 节点所在分片的名称
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 诊断结果为异常的诊断项总数
        /// </summary>
        [JsonProperty("abnormal_sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalSum { get; set; }

        /// <summary>
        /// 诊断失败的诊断项总数
        /// </summary>
        [JsonProperty("failed_sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedSum { get; set; }

        /// <summary>
        /// 节点角色
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// 诊断维度列表
        /// </summary>
        [JsonProperty("diagnosis_dimension_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiagnosisDimension> DiagnosisDimensionList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("command_time_taken_list", NullValueHandling = NullValueHandling.Ignore)]
        public CommandTimeTakenList CommandTimeTakenList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagnosisNodeReport {\n");
            sb.Append("  nodeIp: ").Append(NodeIp).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  abnormalSum: ").Append(AbnormalSum).Append("\n");
            sb.Append("  failedSum: ").Append(FailedSum).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  diagnosisDimensionList: ").Append(DiagnosisDimensionList).Append("\n");
            sb.Append("  commandTimeTakenList: ").Append(CommandTimeTakenList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiagnosisNodeReport);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiagnosisNodeReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
                ) && 
                (
                    this.AzCode == input.AzCode ||
                    (this.AzCode != null &&
                    this.AzCode.Equals(input.AzCode))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.AbnormalSum == input.AbnormalSum ||
                    (this.AbnormalSum != null &&
                    this.AbnormalSum.Equals(input.AbnormalSum))
                ) && 
                (
                    this.FailedSum == input.FailedSum ||
                    (this.FailedSum != null &&
                    this.FailedSum.Equals(input.FailedSum))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.DiagnosisDimensionList == input.DiagnosisDimensionList ||
                    this.DiagnosisDimensionList != null &&
                    input.DiagnosisDimensionList != null &&
                    this.DiagnosisDimensionList.SequenceEqual(input.DiagnosisDimensionList)
                ) && 
                (
                    this.CommandTimeTakenList == input.CommandTimeTakenList ||
                    (this.CommandTimeTakenList != null &&
                    this.CommandTimeTakenList.Equals(input.CommandTimeTakenList))
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
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.AzCode != null)
                    hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.AbnormalSum != null)
                    hashCode = hashCode * 59 + this.AbnormalSum.GetHashCode();
                if (this.FailedSum != null)
                    hashCode = hashCode * 59 + this.FailedSum.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.DiagnosisDimensionList != null)
                    hashCode = hashCode * 59 + this.DiagnosisDimensionList.GetHashCode();
                if (this.CommandTimeTakenList != null)
                    hashCode = hashCode * 59 + this.CommandTimeTakenList.GetHashCode();
                return hashCode;
            }
        }
    }
}

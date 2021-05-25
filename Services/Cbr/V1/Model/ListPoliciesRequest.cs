using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPoliciesRequest 
    {
        /// <summary>
        /// 策略类型：备份（backup）、复制(replication)
        /// </summary>
        /// <value>策略类型：备份（backup）、复制(replication)</value>
        [JsonConverter(typeof(EnumClassConverter<OperationTypeEnum>))]
        public class OperationTypeEnum
        {
            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly OperationTypeEnum BACKUP = new OperationTypeEnum("backup");

            /// <summary>
            /// Enum REPLICATION for value: replication
            /// </summary>
            public static readonly OperationTypeEnum REPLICATION = new OperationTypeEnum("replication");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "backup", BACKUP },
                { "replication", REPLICATION },
            };

            private string Value;

            public OperationTypeEnum(string value)
            {
                Value = value;
            }

            public static OperationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OperationTypeEnum a, OperationTypeEnum b)
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

            public static bool operator !=(OperationTypeEnum a, OperationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 策略类型：备份（backup）、复制(replication)
        /// </summary>
        [SDKProperty("operation_type", IsQuery = true)]
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        /// <summary>
        /// 存储库ID
        /// </summary>
        [SDKProperty("vault_id", IsQuery = true)]
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPoliciesRequest {\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPoliciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPoliciesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.OperationType != null)
                    hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }
    }
}

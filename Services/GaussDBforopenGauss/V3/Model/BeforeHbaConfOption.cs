using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// **参数解释**: 需要修改的hba配置信息。 **约束限制**: 不涉及。
    /// </summary>
    public class BeforeHbaConfOption 
    {
        /// <summary>
        /// **参数解释** 客户端连接类型。 **约束限制**: 不涉及。 **取值范围** - host：表示这条记录既接受一个普通的TCP/IP套接字连接，也接受一个经过SSL加密的TCP/IP套接字连接。 - hostssl：表示这条记录只接受一个经过SSL加密的TCP/IP套接字连接。 - hostnossl：表示这条记录只接受一个普通的TCP/IP套接字连接。  **默认取值**: 不涉及。 
        /// </summary>
        /// <value>**参数解释** 客户端连接类型。 **约束限制**: 不涉及。 **取值范围** - host：表示这条记录既接受一个普通的TCP/IP套接字连接，也接受一个经过SSL加密的TCP/IP套接字连接。 - hostssl：表示这条记录只接受一个经过SSL加密的TCP/IP套接字连接。 - hostnossl：表示这条记录只接受一个普通的TCP/IP套接字连接。  **默认取值**: 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum HOST for value: host
            /// </summary>
            public static readonly TypeEnum HOST = new TypeEnum("host");

            /// <summary>
            /// Enum HOSTNOSSL for value: hostnossl
            /// </summary>
            public static readonly TypeEnum HOSTNOSSL = new TypeEnum("hostnossl");

            /// <summary>
            /// Enum HOSTSSL for value: hostssl
            /// </summary>
            public static readonly TypeEnum HOSTSSL = new TypeEnum("hostssl");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "host", HOST },
                { "hostnossl", HOSTNOSSL },
                { "hostssl", HOSTSSL },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释** 声明连接时使用的认证方法。 **约束限制**: 不涉及。 **取值范围** - reject：无条件地拒绝连接。常用于过滤某些主机。 - md5：MD5加密算法安全性低，存在安全风险，不推荐使用，建议使用更安全的加密算法。默认不支持，可通过password_encryption_type参数配置。 - sha256：要求客户端提供一个sha256算法加密的口令进行认证，该口令在传送过程中结合salt（服务器发送给客户端的随机数）的单向sha256加密，增强了安全性。 - sm3：要求客户端提供一个sm3算法加密口令进行认证，该口令在传送过程中结合salt（服务器发送给客户端的随机数）的单向sm3加密，增加了安全性。 - cert：客户端证书认证模式，此模式需进行SSL连接配置且需要客户端提供有效的SSL证书，不需要提供用户密码。cert认证方式只支持hostssl类型的规则。  **默认取值**: 不涉及。 
        /// </summary>
        /// <value>**参数解释** 声明连接时使用的认证方法。 **约束限制**: 不涉及。 **取值范围** - reject：无条件地拒绝连接。常用于过滤某些主机。 - md5：MD5加密算法安全性低，存在安全风险，不推荐使用，建议使用更安全的加密算法。默认不支持，可通过password_encryption_type参数配置。 - sha256：要求客户端提供一个sha256算法加密的口令进行认证，该口令在传送过程中结合salt（服务器发送给客户端的随机数）的单向sha256加密，增强了安全性。 - sm3：要求客户端提供一个sm3算法加密口令进行认证，该口令在传送过程中结合salt（服务器发送给客户端的随机数）的单向sm3加密，增加了安全性。 - cert：客户端证书认证模式，此模式需进行SSL连接配置且需要客户端提供有效的SSL证书，不需要提供用户密码。cert认证方式只支持hostssl类型的规则。  **默认取值**: 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<MethodEnum>))]
        public class MethodEnum
        {
            /// <summary>
            /// Enum REJECT for value: reject
            /// </summary>
            public static readonly MethodEnum REJECT = new MethodEnum("reject");

            /// <summary>
            /// Enum MD5 for value: md5
            /// </summary>
            public static readonly MethodEnum MD5 = new MethodEnum("md5");

            /// <summary>
            /// Enum SHA256 for value: sha256
            /// </summary>
            public static readonly MethodEnum SHA256 = new MethodEnum("sha256");

            /// <summary>
            /// Enum SM3 for value: sm3
            /// </summary>
            public static readonly MethodEnum SM3 = new MethodEnum("sm3");

            /// <summary>
            /// Enum CERT for value: cert
            /// </summary>
            public static readonly MethodEnum CERT = new MethodEnum("cert");

            private static readonly Dictionary<string, MethodEnum> StaticFields =
            new Dictionary<string, MethodEnum>()
            {
                { "reject", REJECT },
                { "md5", MD5 },
                { "sha256", SHA256 },
                { "sm3", SM3 },
                { "cert", CERT },
            };

            private string _value;

            public MethodEnum()
            {

            }

            public MethodEnum(string value)
            {
                _value = value;
            }

            public static MethodEnum FromValue(string value)
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

                if (this.Equals(obj as MethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MethodEnum a, MethodEnum b)
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

            public static bool operator !=(MethodEnum a, MethodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释** 客户端连接类型。 **约束限制**: 不涉及。 **取值范围** - host：表示这条记录既接受一个普通的TCP/IP套接字连接，也接受一个经过SSL加密的TCP/IP套接字连接。 - hostssl：表示这条记录只接受一个经过SSL加密的TCP/IP套接字连接。 - hostnossl：表示这条记录只接受一个普通的TCP/IP套接字连接。  **默认取值**: 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释** 声明记录所匹配且允许访问的数据库，多租特性场景下该参数声明记录所匹配且允许访问的PDB。 - 值replication表示如果请求一个复制连接，则匹配，但复制连接不表示任何特定的数据库。如需使用名为replication的数据库，需在database列使用记录“replication”作为数据库名。 - 多租数据库下， 值replication_pdb1表示如果请求一个名为pdb1数据库的复制连接，则匹配成功。值replication方式只生效Non-PDB。 - PDB复制连接生效配置方式为replication_[pdbname]，pdbname为用户创建PDB数据库时候的名字。 - 如需使用名为replication_pdb1的数据库，需在database列使用记录“replication_pdb1”作为数据库名。  **约束限制**: 不涉及。 **取值范围** - all：表示该记录匹配所有数据库。 - 特定的数据库名称或者用逗号分隔的数据库列表。  **默认取值**: 不涉及。 
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// **参数解释** 声明记录所匹配且允许访问的数据库用户。 **约束限制** 不支持系统用户。 **取值范围** - all：表明该记录匹配所有用户。 - 特定的数据库用户名或者用逗号分隔的用户列表。 **默认取值**: 不涉及。 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// **参数解释** 指定与记录匹配且允许访问的IP地址范围。 **约束限制** 当前仅支持IP地址/掩码长度格式。 数据库引擎版本为V2.0-8.1.0及以上支持address配置IPv6的IP。 **取值范围** 支持IPv4和IPv6，可以使用如下形式来表示： IP地址/掩码长度。例如，10.10.0.0/24、2001:250:250:250:250:250:250:175/128。 **默认取值**: 不涉及。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// **参数解释** 声明连接时使用的认证方法。 **约束限制**: 不涉及。 **取值范围** - reject：无条件地拒绝连接。常用于过滤某些主机。 - md5：MD5加密算法安全性低，存在安全风险，不推荐使用，建议使用更安全的加密算法。默认不支持，可通过password_encryption_type参数配置。 - sha256：要求客户端提供一个sha256算法加密的口令进行认证，该口令在传送过程中结合salt（服务器发送给客户端的随机数）的单向sha256加密，增强了安全性。 - sm3：要求客户端提供一个sm3算法加密口令进行认证，该口令在传送过程中结合salt（服务器发送给客户端的随机数）的单向sm3加密，增加了安全性。 - cert：客户端证书认证模式，此模式需进行SSL连接配置且需要客户端提供有效的SSL证书，不需要提供用户密码。cert认证方式只支持hostssl类型的规则。  **默认取值**: 不涉及。 
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public MethodEnum Method { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeforeHbaConfOption {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BeforeHbaConfOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BeforeHbaConfOption input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Database != input.Database || (this.Database != null && !this.Database.Equals(input.Database))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Method != input.Method) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Database != null) hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                hashCode = hashCode * 59 + this.Method.GetHashCode();
                return hashCode;
            }
        }
    }
}

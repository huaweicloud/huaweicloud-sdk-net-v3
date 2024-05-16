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
    public class ClientInfo 
    {
        /// <summary>
        /// 文件描述符事件
        /// </summary>
        /// <value>文件描述符事件</value>
        [JsonConverter(typeof(EnumClassConverter<EventsEnum>))]
        public class EventsEnum
        {
            /// <summary>
            /// Enum R for value: r
            /// </summary>
            public static readonly EventsEnum R = new EventsEnum("r");

            /// <summary>
            /// Enum W for value: w
            /// </summary>
            public static readonly EventsEnum W = new EventsEnum("w");

            private static readonly Dictionary<string, EventsEnum> StaticFields =
            new Dictionary<string, EventsEnum>()
            {
                { "r", R },
                { "w", W },
            };

            private string _value;

            public EventsEnum()
            {

            }

            public EventsEnum(string value)
            {
                _value = value;
            }

            public static EventsEnum FromValue(string value)
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

                if (this.Equals(obj as EventsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventsEnum a, EventsEnum b)
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

            public static bool operator !=(EventsEnum a, EventsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 客户端的地址和端口
        /// </summary>
        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string Addr { get; set; }

        /// <summary>
        /// 套接字所使用的文件描述符。
        /// </summary>
        [JsonProperty("fd", NullValueHandling = NullValueHandling.Ignore)]
        public string Fd { get; set; }

        /// <summary>
        /// 客户端的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 最近一次执行的命令
        /// </summary>
        [JsonProperty("cmd", NullValueHandling = NullValueHandling.Ignore)]
        public string Cmd { get; set; }

        /// <summary>
        /// 已连接时长（单位：秒）
        /// </summary>
        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; set; }

        /// <summary>
        /// 空闲时长（单位：秒）
        /// </summary>
        [JsonProperty("idle", NullValueHandling = NullValueHandling.Ignore)]
        public int? Idle { get; set; }

        /// <summary>
        /// 该客户端正在使用的数据库 ID
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public string Db { get; set; }

        /// <summary>
        /// 客户端标志
        /// </summary>
        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public string Flags { get; set; }

        /// <summary>
        /// 已订阅频道的数量
        /// </summary>
        [JsonProperty("sub", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sub { get; set; }

        /// <summary>
        /// 已订阅模式的数量
        /// </summary>
        [JsonProperty("psub", NullValueHandling = NullValueHandling.Ignore)]
        public int? Psub { get; set; }

        /// <summary>
        /// 在事务中被执行的命令数量
        /// </summary>
        [JsonProperty("multi", NullValueHandling = NullValueHandling.Ignore)]
        public int? Multi { get; set; }

        /// <summary>
        /// 查询缓冲区的长度（单位为字节， 0 表示没有分配查询缓冲区）
        /// </summary>
        [JsonProperty("qbuf", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbuf { get; set; }

        /// <summary>
        /// 查询缓冲区剩余空间的长度（单位为字节， 0 表示没有剩余空间）
        /// </summary>
        [JsonProperty("qbuf_free", NullValueHandling = NullValueHandling.Ignore)]
        public int? QbufFree { get; set; }

        /// <summary>
        /// 输出缓冲区的长度（单位为字节， 0 表示没有分配输出缓冲区）
        /// </summary>
        [JsonProperty("obl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Obl { get; set; }

        /// <summary>
        /// 输出列表包含的对象数量（当输出缓冲区没有剩余空间时，命令回复会以字符串对象的形式被入队到这个队列里）
        /// </summary>
        [JsonProperty("oll", NullValueHandling = NullValueHandling.Ignore)]
        public int? Oll { get; set; }

        /// <summary>
        /// 输出缓冲区和输出列表占用的内存总量
        /// </summary>
        [JsonProperty("omem", NullValueHandling = NullValueHandling.Ignore)]
        public int? Omem { get; set; }

        /// <summary>
        /// 文件描述符事件
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public EventsEnum Events { get; set; }
        /// <summary>
        /// 客户端所使用的网络类型。
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public string Network { get; set; }

        /// <summary>
        /// 单机，主备和cluster实例地址和端口。
        /// </summary>
        [JsonProperty("peer", NullValueHandling = NullValueHandling.Ignore)]
        public string Peer { get; set; }

        /// <summary>
        /// 客户端用户。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  addr: ").Append(Addr).Append("\n");
            sb.Append("  fd: ").Append(Fd).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  cmd: ").Append(Cmd).Append("\n");
            sb.Append("  age: ").Append(Age).Append("\n");
            sb.Append("  idle: ").Append(Idle).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  flags: ").Append(Flags).Append("\n");
            sb.Append("  sub: ").Append(Sub).Append("\n");
            sb.Append("  psub: ").Append(Psub).Append("\n");
            sb.Append("  multi: ").Append(Multi).Append("\n");
            sb.Append("  qbuf: ").Append(Qbuf).Append("\n");
            sb.Append("  qbufFree: ").Append(QbufFree).Append("\n");
            sb.Append("  obl: ").Append(Obl).Append("\n");
            sb.Append("  oll: ").Append(Oll).Append("\n");
            sb.Append("  omem: ").Append(Omem).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("  network: ").Append(Network).Append("\n");
            sb.Append("  peer: ").Append(Peer).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClientInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Addr == input.Addr ||
                    (this.Addr != null &&
                    this.Addr.Equals(input.Addr))
                ) && 
                (
                    this.Fd == input.Fd ||
                    (this.Fd != null &&
                    this.Fd.Equals(input.Fd))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Cmd == input.Cmd ||
                    (this.Cmd != null &&
                    this.Cmd.Equals(input.Cmd))
                ) && 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
                ) && 
                (
                    this.Idle == input.Idle ||
                    (this.Idle != null &&
                    this.Idle.Equals(input.Idle))
                ) && 
                (
                    this.Db == input.Db ||
                    (this.Db != null &&
                    this.Db.Equals(input.Db))
                ) && 
                (
                    this.Flags == input.Flags ||
                    (this.Flags != null &&
                    this.Flags.Equals(input.Flags))
                ) && 
                (
                    this.Sub == input.Sub ||
                    (this.Sub != null &&
                    this.Sub.Equals(input.Sub))
                ) && 
                (
                    this.Psub == input.Psub ||
                    (this.Psub != null &&
                    this.Psub.Equals(input.Psub))
                ) && 
                (
                    this.Multi == input.Multi ||
                    (this.Multi != null &&
                    this.Multi.Equals(input.Multi))
                ) && 
                (
                    this.Qbuf == input.Qbuf ||
                    (this.Qbuf != null &&
                    this.Qbuf.Equals(input.Qbuf))
                ) && 
                (
                    this.QbufFree == input.QbufFree ||
                    (this.QbufFree != null &&
                    this.QbufFree.Equals(input.QbufFree))
                ) && 
                (
                    this.Obl == input.Obl ||
                    (this.Obl != null &&
                    this.Obl.Equals(input.Obl))
                ) && 
                (
                    this.Oll == input.Oll ||
                    (this.Oll != null &&
                    this.Oll.Equals(input.Oll))
                ) && 
                (
                    this.Omem == input.Omem ||
                    (this.Omem != null &&
                    this.Omem.Equals(input.Omem))
                ) && 
                (
                    this.Events == input.Events ||
                    (this.Events != null &&
                    this.Events.Equals(input.Events))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Peer == input.Peer ||
                    (this.Peer != null &&
                    this.Peer.Equals(input.Peer))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Addr != null)
                    hashCode = hashCode * 59 + this.Addr.GetHashCode();
                if (this.Fd != null)
                    hashCode = hashCode * 59 + this.Fd.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Cmd != null)
                    hashCode = hashCode * 59 + this.Cmd.GetHashCode();
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                if (this.Idle != null)
                    hashCode = hashCode * 59 + this.Idle.GetHashCode();
                if (this.Db != null)
                    hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Sub != null)
                    hashCode = hashCode * 59 + this.Sub.GetHashCode();
                if (this.Psub != null)
                    hashCode = hashCode * 59 + this.Psub.GetHashCode();
                if (this.Multi != null)
                    hashCode = hashCode * 59 + this.Multi.GetHashCode();
                if (this.Qbuf != null)
                    hashCode = hashCode * 59 + this.Qbuf.GetHashCode();
                if (this.QbufFree != null)
                    hashCode = hashCode * 59 + this.QbufFree.GetHashCode();
                if (this.Obl != null)
                    hashCode = hashCode * 59 + this.Obl.GetHashCode();
                if (this.Oll != null)
                    hashCode = hashCode * 59 + this.Oll.GetHashCode();
                if (this.Omem != null)
                    hashCode = hashCode * 59 + this.Omem.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Peer != null)
                    hashCode = hashCode * 59 + this.Peer.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListInstancesSessionRespondBodySessions 
    {

        /// <summary>
        /// 客户端的地址和端口。
        /// </summary>
        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string Addr { get; set; }

        /// <summary>
        /// 会话id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 连接名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 最近一次执行的命令。
        /// </summary>
        [JsonProperty("cmd", NullValueHandling = NullValueHandling.Ignore)]
        public string Cmd { get; set; }

        /// <summary>
        /// 以秒计算的已连接时长。
        /// </summary>
        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public string Age { get; set; }

        /// <summary>
        /// 以秒计算的空闲时长。
        /// </summary>
        [JsonProperty("idle", NullValueHandling = NullValueHandling.Ignore)]
        public string Idle { get; set; }

        /// <summary>
        /// 该客户端正在使用的数据库 ID。
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public string Db { get; set; }

        /// <summary>
        /// 套接字所使用的文件描述符。
        /// </summary>
        [JsonProperty("fd", NullValueHandling = NullValueHandling.Ignore)]
        public string Fd { get; set; }

        /// <summary>
        /// 已订阅频道的数量。
        /// </summary>
        [JsonProperty("sub", NullValueHandling = NullValueHandling.Ignore)]
        public string Sub { get; set; }

        /// <summary>
        /// 已订阅模式的数量。
        /// </summary>
        [JsonProperty("psub", NullValueHandling = NullValueHandling.Ignore)]
        public string Psub { get; set; }

        /// <summary>
        /// 在事务中被执行的命令数量。
        /// </summary>
        [JsonProperty("multi", NullValueHandling = NullValueHandling.Ignore)]
        public string Multi { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesSessionRespondBodySessions {\n");
            sb.Append("  addr: ").Append(Addr).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  cmd: ").Append(Cmd).Append("\n");
            sb.Append("  age: ").Append(Age).Append("\n");
            sb.Append("  idle: ").Append(Idle).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  fd: ").Append(Fd).Append("\n");
            sb.Append("  sub: ").Append(Sub).Append("\n");
            sb.Append("  psub: ").Append(Psub).Append("\n");
            sb.Append("  multi: ").Append(Multi).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesSessionRespondBodySessions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesSessionRespondBodySessions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Addr == input.Addr ||
                    (this.Addr != null &&
                    this.Addr.Equals(input.Addr))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Fd == input.Fd ||
                    (this.Fd != null &&
                    this.Fd.Equals(input.Fd))
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
                if (this.Addr != null)
                    hashCode = hashCode * 59 + this.Addr.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
                if (this.Fd != null)
                    hashCode = hashCode * 59 + this.Fd.GetHashCode();
                if (this.Sub != null)
                    hashCode = hashCode * 59 + this.Sub.GetHashCode();
                if (this.Psub != null)
                    hashCode = hashCode * 59 + this.Psub.GetHashCode();
                if (this.Multi != null)
                    hashCode = hashCode * 59 + this.Multi.GetHashCode();
                return hashCode;
            }
        }
    }
}

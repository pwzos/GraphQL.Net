﻿using GraphQL.Net.Subscription.Model;
using GraphQL.Types;

namespace GraphQL.Net.Subscription.Schema.Type
{
    public class MessageType:ObjectGraphType<Messages>
    {
        public MessageType()
        {
            Name = "messageType";
            Description = "消息";
            Field(m => m.FromId).Description("消息发送者的编号");
            Field(m => m.FromName).Description("消息发送者的姓名");
            Field(m => m.ToId).Description("消息接收者的编号");
            Field(m => m.ToName).Description("消息接收着的姓名");
            Field(m => m.Content).Description("消息内容");
            Field(m => m.SendTime).Description("消息发送时间");
        }
    }
}

/*
 * xPilot: X-Plane pilot client for VATSIM
 * Copyright (C) 2019-2021 Justin Shannon
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see http://www.gnu.org/licenses/.
*/

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PrivateMessageSent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Vatsim.Xpilot.Protobuf {

  /// <summary>Holder for reflection information generated from PrivateMessageSent.proto</summary>
  public static partial class PrivateMessageSentReflection {

    #region Descriptor
    /// <summary>File descriptor for PrivateMessageSent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PrivateMessageSentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQcml2YXRlTWVzc2FnZVNlbnQucHJvdG8SBnhwaWxvdCJOChJQcml2YXRl",
            "TWVzc2FnZVNlbnQSDwoCdG8YASABKAlIAIgBARIUCgdtZXNzYWdlGAIgASgJ",
            "SAGIAQFCBQoDX3RvQgoKCF9tZXNzYWdlQhmqAhZWYXRzaW0uWHBpbG90LlBy",
            "b3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Vatsim.Xpilot.Protobuf.PrivateMessageSent), global::Vatsim.Xpilot.Protobuf.PrivateMessageSent.Parser, new[]{ "To", "Message" }, new[]{ "To", "Message" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PrivateMessageSent : pb::IMessage<PrivateMessageSent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PrivateMessageSent> _parser = new pb::MessageParser<PrivateMessageSent>(() => new PrivateMessageSent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PrivateMessageSent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Vatsim.Xpilot.Protobuf.PrivateMessageSentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrivateMessageSent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrivateMessageSent(PrivateMessageSent other) : this() {
      to_ = other.to_;
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrivateMessageSent Clone() {
      return new PrivateMessageSent(this);
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 1;
    private string to_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string To {
      get { return to_ ?? ""; }
      set {
        to_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "to" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasTo {
      get { return to_ != null; }
    }
    /// <summary>Clears the value of the "to" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTo() {
      to_ = null;
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_ ?? ""; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "message" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasMessage {
      get { return message_ != null; }
    }
    /// <summary>Clears the value of the "message" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMessage() {
      message_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PrivateMessageSent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PrivateMessageSent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (To != other.To) return false;
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasTo) hash ^= To.GetHashCode();
      if (HasMessage) hash ^= Message.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasTo) {
        output.WriteRawTag(10);
        output.WriteString(To);
      }
      if (HasMessage) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasTo) {
        output.WriteRawTag(10);
        output.WriteString(To);
      }
      if (HasMessage) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasTo) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(To);
      }
      if (HasMessage) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PrivateMessageSent other) {
      if (other == null) {
        return;
      }
      if (other.HasTo) {
        To = other.To;
      }
      if (other.HasMessage) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            To = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            To = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
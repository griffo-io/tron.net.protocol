// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tronprotocol/core/contract/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tron.Net.Protocol {

  /// <summary>Holder for reflection information generated from tronprotocol/core/contract/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for tronprotocol/core/contract/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cid0cm9ucHJvdG9jb2wvY29yZS9jb250cmFjdC9jb21tb24ucHJvdG8SCHBy",
            "b3RvY29sKikKDFJlc291cmNlQ29kZRINCglCQU5EV0lEVEgQABIKCgZFTkVS",
            "R1kQAUJZChhvcmcudHJvbi5wcm90b3MuY29udHJhY3RaKWdpdGh1Yi5jb20v",
            "dHJvbnByb3RvY29sL2dycGMtZ2F0ZXdheS9jb3JlqgIRVHJvbi5OZXQuUHJv",
            "dG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Tron.Net.Protocol.ResourceCode), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ResourceCode {
    [pbr::OriginalName("BANDWIDTH")] Bandwidth = 0,
    [pbr::OriginalName("ENERGY")] Energy = 1,
  }

  #endregion

}

#endregion Designer generated code

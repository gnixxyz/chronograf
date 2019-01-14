// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Apache.Arrow.Flatbuf
{

using global::System;
using global::FlatBuffers;

public struct Block : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Block __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  /// Index to the start of the RecordBlock (note this is past the Message header)
  public long Offset { get { return __p.bb.GetLong(__p.bb_pos + 0); } }
  /// Length of the metadata
  public int MetaDataLength { get { return __p.bb.GetInt(__p.bb_pos + 8); } }
  /// Length of the data (this is aligned so there can be a gap between this and
  /// the metatdata).
  public long BodyLength { get { return __p.bb.GetLong(__p.bb_pos + 16); } }

  public static Offset<Block> CreateBlock(FlatBufferBuilder builder, long Offset, int MetaDataLength, long BodyLength) {
    builder.Prep(8, 24);
    builder.PutLong(BodyLength);
    builder.Pad(4);
    builder.PutInt(MetaDataLength);
    builder.PutLong(Offset);
    return new Offset<Block>(builder.Offset);
  }
};


}

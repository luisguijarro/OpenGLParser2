// OpenGL 1.2 Commands.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;
using System.Runtime.InteropServices;

namespace fgtk.OpenGL
{
	public static class OpenGL1_2
	{
		public static void glAccum(AccumOp op, Single value)
		{
			i_OpenGL1_2.glAccum(op, value);
		}
		public static void glAlphaFunc(AlphaFunction func, Single @ref)
		{
			i_OpenGL1_2.glAlphaFunc(func, @ref);
		}
		public static Boolean glAreTexturesResident(Int32 n, ref UInt32[] textures, ref Boolean[] residences)
		{
			return i_OpenGL1_2.glAreTexturesResident(n, ref textures, ref residences);
		}
		public static void glArrayElement(Int32 i)
		{
			i_OpenGL1_2.glArrayElement(i);
		}
		public static void glBegin(PrimitiveType mode)
		{
			i_OpenGL1_2.glBegin(mode);
		}
		public static void glBindTexture(TextureTarget target, UInt32 texture)
		{
			i_OpenGL1_2.glBindTexture(target, texture);
		}
		public static void glBitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, ref Byte[] bitmap)
		{
			i_OpenGL1_2.glBitmap(width, height, xorig, yorig, xmove, ymove, ref bitmap);
		}
		public static void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			i_OpenGL1_2.glBlendFunc(sfactor, dfactor);
		}
		public static void glCallList(UInt32 list)
		{
			i_OpenGL1_2.glCallList(list);
		}
		public static void glCallLists(Int32 n, ListNameType type, IntPtr lists)
		{
			i_OpenGL1_2.glCallLists(n, type, lists);
		}
		public static void glClear(UInt32 mask)
		{
			i_OpenGL1_2.glClear(mask);
		}
		public static void glClearAccum(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL1_2.glClearAccum(red, green, blue, alpha);
		}
		public static void glClearColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL1_2.glClearColor(red, green, blue, alpha);
		}
		public static void glClearDepth(Double depth)
		{
			i_OpenGL1_2.glClearDepth(depth);
		}
		public static void glClearIndex(Single c)
		{
			i_OpenGL1_2.glClearIndex(c);
		}
		public static void glClearStencil(Int32 s)
		{
			i_OpenGL1_2.glClearStencil(s);
		}
		public static void glClipPlane(ClipPlaneName plane, ref Double[] equation)
		{
			i_OpenGL1_2.glClipPlane(plane, ref equation);
		}
		public static void glColor3b(SByte red, SByte green, SByte blue)
		{
			i_OpenGL1_2.glColor3b(red, green, blue);
		}
		public static void glColor3bv(ref SByte[] v)
		{
			i_OpenGL1_2.glColor3bv(ref v);
		}
		public static void glColor3d(Double red, Double green, Double blue)
		{
			i_OpenGL1_2.glColor3d(red, green, blue);
		}
		public static void glColor3dv(ref Double[] v)
		{
			i_OpenGL1_2.glColor3dv(ref v);
		}
		public static void glColor3f(Single red, Single green, Single blue)
		{
			i_OpenGL1_2.glColor3f(red, green, blue);
		}
		public static void glColor3fv(ref Single[] v)
		{
			i_OpenGL1_2.glColor3fv(ref v);
		}
		public static void glColor3i(Int32 red, Int32 green, Int32 blue)
		{
			i_OpenGL1_2.glColor3i(red, green, blue);
		}
		public static void glColor3iv(ref Int32[] v)
		{
			i_OpenGL1_2.glColor3iv(ref v);
		}
		public static void glColor3s(Int16 red, Int16 green, Int16 blue)
		{
			i_OpenGL1_2.glColor3s(red, green, blue);
		}
		public static void glColor3sv(ref Int16[] v)
		{
			i_OpenGL1_2.glColor3sv(ref v);
		}
		public static void glColor3ub(Byte red, Byte green, Byte blue)
		{
			i_OpenGL1_2.glColor3ub(red, green, blue);
		}
		public static void glColor3ubv(ref Byte[] v)
		{
			i_OpenGL1_2.glColor3ubv(ref v);
		}
		public static void glColor3ui(UInt32 red, UInt32 green, UInt32 blue)
		{
			i_OpenGL1_2.glColor3ui(red, green, blue);
		}
		public static void glColor3uiv(ref UInt32[] v)
		{
			i_OpenGL1_2.glColor3uiv(ref v);
		}
		public static void glColor3us(UInt16 red, UInt16 green, UInt16 blue)
		{
			i_OpenGL1_2.glColor3us(red, green, blue);
		}
		public static void glColor3usv(ref UInt16[] v)
		{
			i_OpenGL1_2.glColor3usv(ref v);
		}
		public static void glColor4b(SByte red, SByte green, SByte blue, SByte alpha)
		{
			i_OpenGL1_2.glColor4b(red, green, blue, alpha);
		}
		public static void glColor4bv(ref SByte[] v)
		{
			i_OpenGL1_2.glColor4bv(ref v);
		}
		public static void glColor4d(Double red, Double green, Double blue, Double alpha)
		{
			i_OpenGL1_2.glColor4d(red, green, blue, alpha);
		}
		public static void glColor4dv(ref Double[] v)
		{
			i_OpenGL1_2.glColor4dv(ref v);
		}
		public static void glColor4f(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL1_2.glColor4f(red, green, blue, alpha);
		}
		public static void glColor4fv(ref Single[] v)
		{
			i_OpenGL1_2.glColor4fv(ref v);
		}
		public static void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			i_OpenGL1_2.glColor4i(red, green, blue, alpha);
		}
		public static void glColor4iv(ref Int32[] v)
		{
			i_OpenGL1_2.glColor4iv(ref v);
		}
		public static void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha)
		{
			i_OpenGL1_2.glColor4s(red, green, blue, alpha);
		}
		public static void glColor4sv(ref Int16[] v)
		{
			i_OpenGL1_2.glColor4sv(ref v);
		}
		public static void glColor4ub(Byte red, Byte green, Byte blue, Byte alpha)
		{
			i_OpenGL1_2.glColor4ub(red, green, blue, alpha);
		}
		public static void glColor4ubv(ref Byte[] v)
		{
			i_OpenGL1_2.glColor4ubv(ref v);
		}
		public static void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha)
		{
			i_OpenGL1_2.glColor4ui(red, green, blue, alpha);
		}
		public static void glColor4uiv(ref UInt32[] v)
		{
			i_OpenGL1_2.glColor4uiv(ref v);
		}
		public static void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha)
		{
			i_OpenGL1_2.glColor4us(red, green, blue, alpha);
		}
		public static void glColor4usv(ref UInt16[] v)
		{
			i_OpenGL1_2.glColor4usv(ref v);
		}
		public static void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
		{
			i_OpenGL1_2.glColorMask(red, green, blue, alpha);
		}
		public static void glColorMaterial(MaterialFace face, ColorMaterialParameter mode)
		{
			i_OpenGL1_2.glColorMaterial(face, mode);
		}
		public static void glColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL1_2.glColorPointer(size, type, stride, pointer);
		}
		public static void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelCopyType type)
		{
			i_OpenGL1_2.glCopyPixels(x, y, width, height, type);
		}
		public static void glCopyTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			i_OpenGL1_2.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}
		public static void glCopyTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			i_OpenGL1_2.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}
		public static void glCopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			i_OpenGL1_2.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}
		public static void glCopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL1_2.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}
		public static void glCopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL1_2.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		public static void glCullFace(CullFaceMode mode)
		{
			i_OpenGL1_2.glCullFace(mode);
		}
		public static void glDeleteLists(UInt32 list, Int32 range)
		{
			i_OpenGL1_2.glDeleteLists(list, range);
		}
		public static void glDeleteTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL1_2.glDeleteTextures(n, ref textures);
		}
		public static void glDepthFunc(DepthFunction func)
		{
			i_OpenGL1_2.glDepthFunc(func);
		}
		public static void glDepthMask(Boolean flag)
		{
			i_OpenGL1_2.glDepthMask(flag);
		}
		public static void glDepthRange(Double n, Double f)
		{
			i_OpenGL1_2.glDepthRange(n, f);
		}
		public static void glDisable(EnableCap cap)
		{
			i_OpenGL1_2.glDisable(cap);
		}
		public static void glDisableClientState(EnableCap array)
		{
			i_OpenGL1_2.glDisableClientState(array);
		}
		public static void glDrawArrays(PrimitiveType mode, Int32 first, Int32 count)
		{
			i_OpenGL1_2.glDrawArrays(mode, first, count);
		}
		public static void glDrawBuffer(DrawBufferMode buf)
		{
			i_OpenGL1_2.glDrawBuffer(buf);
		}
		public static void glDrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL1_2.glDrawElements(mode, count, type, indices);
		}
		public static void glDrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glDrawPixels(width, height, format, type, pixels);
		}
		public static void glDrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL1_2.glDrawRangeElements(mode, start, end, count, type, indices);
		}
		public static void glEdgeFlag(Boolean flag)
		{
			i_OpenGL1_2.glEdgeFlag(flag);
		}
		public static void glEdgeFlagPointer(Int32 stride, IntPtr pointer)
		{
			i_OpenGL1_2.glEdgeFlagPointer(stride, pointer);
		}
		public static void glEdgeFlagv(ref Boolean flag)
		{
			i_OpenGL1_2.glEdgeFlagv(ref flag);
		}
		public static void glEnable(EnableCap cap)
		{
			i_OpenGL1_2.glEnable(cap);
		}
		public static void glEnableClientState(EnableCap array)
		{
			i_OpenGL1_2.glEnableClientState(array);
		}
		public static void glEnd()
		{
			i_OpenGL1_2.glEnd();
		}
		public static void glEndList()
		{
			i_OpenGL1_2.glEndList();
		}
		public static void glEvalCoord1d(Double u)
		{
			i_OpenGL1_2.glEvalCoord1d(u);
		}
		public static void glEvalCoord1dv(ref Double u)
		{
			i_OpenGL1_2.glEvalCoord1dv(ref u);
		}
		public static void glEvalCoord1f(Single u)
		{
			i_OpenGL1_2.glEvalCoord1f(u);
		}
		public static void glEvalCoord1fv(ref Single u)
		{
			i_OpenGL1_2.glEvalCoord1fv(ref u);
		}
		public static void glEvalCoord2d(Double u, Double v)
		{
			i_OpenGL1_2.glEvalCoord2d(u, v);
		}
		public static void glEvalCoord2dv(ref Double[] u)
		{
			i_OpenGL1_2.glEvalCoord2dv(ref u);
		}
		public static void glEvalCoord2f(Single u, Single v)
		{
			i_OpenGL1_2.glEvalCoord2f(u, v);
		}
		public static void glEvalCoord2fv(ref Single[] u)
		{
			i_OpenGL1_2.glEvalCoord2fv(ref u);
		}
		public static void glEvalMesh1(MeshMode1 mode, Int32 i1, Int32 i2)
		{
			i_OpenGL1_2.glEvalMesh1(mode, i1, i2);
		}
		public static void glEvalMesh2(MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2)
		{
			i_OpenGL1_2.glEvalMesh2(mode, i1, i2, j1, j2);
		}
		public static void glEvalPoint1(Int32 i)
		{
			i_OpenGL1_2.glEvalPoint1(i);
		}
		public static void glEvalPoint2(Int32 i, Int32 j)
		{
			i_OpenGL1_2.glEvalPoint2(i, j);
		}
		public static void glFeedbackBuffer(Int32 size, FeedbackType type, ref Single[] buffer)
		{
			i_OpenGL1_2.glFeedbackBuffer(size, type, ref buffer);
		}
		public static void glFinish()
		{
			i_OpenGL1_2.glFinish();
		}
		public static void glFlush()
		{
			i_OpenGL1_2.glFlush();
		}
		public static void glFogf(FogParameter pname, Single param)
		{
			i_OpenGL1_2.glFogf(pname, param);
		}
		public static void glFogfv(FogParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glFogfv(pname, ref @params);
		}
		public static void glFogi(FogParameter pname, Int32 param)
		{
			i_OpenGL1_2.glFogi(pname, param);
		}
		public static void glFogiv(FogParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glFogiv(pname, ref @params);
		}
		public static void glFrontFace(FrontFaceDirection mode)
		{
			i_OpenGL1_2.glFrontFace(mode);
		}
		public static void glFrustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar)
		{
			i_OpenGL1_2.glFrustum(left, right, bottom, top, zNear, zFar);
		}
		public static UInt32 glGenLists(Int32 range)
		{
			return i_OpenGL1_2.glGenLists(range);
		}
		public static void glGenTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL1_2.glGenTextures(n, ref textures);
		}
		public static void glGetBooleanv(GetPName pname, ref Boolean[] data)
		{
			i_OpenGL1_2.glGetBooleanv(pname, ref data);
		}
		public static void glGetClipPlane(ClipPlaneName plane, ref Double[] equation)
		{
			i_OpenGL1_2.glGetClipPlane(plane, ref equation);
		}
		public static void glGetDoublev(GetPName pname, ref Double[] data)
		{
			i_OpenGL1_2.glGetDoublev(pname, ref data);
		}
		public static ErrorCode glGetError()
		{
			return i_OpenGL1_2.glGetError();
		}
		public static void glGetFloatv(GetPName pname, ref Single[] data)
		{
			i_OpenGL1_2.glGetFloatv(pname, ref data);
		}
		public static void glGetIntegerv(GetPName pname, ref Int32[] data)
		{
			i_OpenGL1_2.glGetIntegerv(pname, ref data);
		}
		public static void glGetLightfv(LightName light, LightParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glGetLightfv(light, pname, ref @params);
		}
		public static void glGetLightiv(LightName light, LightParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glGetLightiv(light, pname, ref @params);
		}
		public static void glGetMapdv(MapTarget target, GetMapQuery query, ref Double[] v)
		{
			i_OpenGL1_2.glGetMapdv(target, query, ref v);
		}
		public static void glGetMapfv(MapTarget target, GetMapQuery query, ref Single[] v)
		{
			i_OpenGL1_2.glGetMapfv(target, query, ref v);
		}
		public static void glGetMapiv(MapTarget target, GetMapQuery query, ref Int32[] v)
		{
			i_OpenGL1_2.glGetMapiv(target, query, ref v);
		}
		public static void glGetMaterialfv(MaterialFace face, MaterialParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glGetMaterialfv(face, pname, ref @params);
		}
		public static void glGetMaterialiv(MaterialFace face, MaterialParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glGetMaterialiv(face, pname, ref @params);
		}
		public static void glGetPixelMapfv(PixelMap map, ref Single[] values)
		{
			i_OpenGL1_2.glGetPixelMapfv(map, ref values);
		}
		public static void glGetPixelMapuiv(PixelMap map, ref UInt32[] values)
		{
			i_OpenGL1_2.glGetPixelMapuiv(map, ref values);
		}
		public static void glGetPixelMapusv(PixelMap map, ref UInt16[] values)
		{
			i_OpenGL1_2.glGetPixelMapusv(map, ref values);
		}
		public static void glGetPointerv(GetPointervPName pname, IntPtr @params)
		{
			i_OpenGL1_2.glGetPointerv(pname, @params);
		}
		public static void glGetPolygonStipple(ref Byte[] mask)
		{
			i_OpenGL1_2.glGetPolygonStipple(ref mask);
		}
		public static Byte glGetString(StringName name)
		{
			return i_OpenGL1_2.glGetString(name);
		}
		public static void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glGetTexEnvfv(target, pname, ref @params);
		}
		public static void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glGetTexEnviv(target, pname, ref @params);
		}
		public static void glGetTexGendv(TextureCoordName coord, TextureGenParameter pname, ref Double[] @params)
		{
			i_OpenGL1_2.glGetTexGendv(coord, pname, ref @params);
		}
		public static void glGetTexGenfv(TextureCoordName coord, TextureGenParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glGetTexGenfv(coord, pname, ref @params);
		}
		public static void glGetTexGeniv(TextureCoordName coord, TextureGenParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glGetTexGeniv(coord, pname, ref @params);
		}
		public static void glGetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glGetTexImage(target, level, format, type, pixels);
		}
		public static void glGetTexLevelParameterfv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glGetTexLevelParameterfv(target, level, pname, ref @params);
		}
		public static void glGetTexLevelParameteriv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glGetTexLevelParameteriv(target, level, pname, ref @params);
		}
		public static void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glGetTexParameterfv(target, pname, ref @params);
		}
		public static void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glGetTexParameteriv(target, pname, ref @params);
		}
		public static void glHint(HintTarget target, HintMode mode)
		{
			i_OpenGL1_2.glHint(target, mode);
		}
		public static void glIndexd(Double c)
		{
			i_OpenGL1_2.glIndexd(c);
		}
		public static void glIndexdv(ref Double c)
		{
			i_OpenGL1_2.glIndexdv(ref c);
		}
		public static void glIndexf(Single c)
		{
			i_OpenGL1_2.glIndexf(c);
		}
		public static void glIndexfv(ref Single c)
		{
			i_OpenGL1_2.glIndexfv(ref c);
		}
		public static void glIndexi(Int32 c)
		{
			i_OpenGL1_2.glIndexi(c);
		}
		public static void glIndexiv(ref Int32 c)
		{
			i_OpenGL1_2.glIndexiv(ref c);
		}
		public static void glIndexMask(UInt32 mask)
		{
			i_OpenGL1_2.glIndexMask(mask);
		}
		public static void glIndexPointer(IndexPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL1_2.glIndexPointer(type, stride, pointer);
		}
		public static void glIndexs(Int16 c)
		{
			i_OpenGL1_2.glIndexs(c);
		}
		public static void glIndexsv(ref Int16 c)
		{
			i_OpenGL1_2.glIndexsv(ref c);
		}
		public static void glIndexub(Byte c)
		{
			i_OpenGL1_2.glIndexub(c);
		}
		public static void glIndexubv(ref Byte c)
		{
			i_OpenGL1_2.glIndexubv(ref c);
		}
		public static void glInitNames()
		{
			i_OpenGL1_2.glInitNames();
		}
		public static void glInterleavedArrays(InterleavedArrayFormat format, Int32 stride, IntPtr pointer)
		{
			i_OpenGL1_2.glInterleavedArrays(format, stride, pointer);
		}
		public static Boolean glIsEnabled(EnableCap cap)
		{
			return i_OpenGL1_2.glIsEnabled(cap);
		}
		public static Boolean glIsList(UInt32 list)
		{
			return i_OpenGL1_2.glIsList(list);
		}
		public static Boolean glIsTexture(UInt32 texture)
		{
			return i_OpenGL1_2.glIsTexture(texture);
		}
		public static void glLightf(LightName light, LightParameter pname, Single param)
		{
			i_OpenGL1_2.glLightf(light, pname, param);
		}
		public static void glLightfv(LightName light, LightParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glLightfv(light, pname, ref @params);
		}
		public static void glLighti(LightName light, LightParameter pname, Int32 param)
		{
			i_OpenGL1_2.glLighti(light, pname, param);
		}
		public static void glLightiv(LightName light, LightParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glLightiv(light, pname, ref @params);
		}
		public static void glLightModelf(LightModelParameter pname, Single param)
		{
			i_OpenGL1_2.glLightModelf(pname, param);
		}
		public static void glLightModelfv(LightModelParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glLightModelfv(pname, ref @params);
		}
		public static void glLightModeli(LightModelParameter pname, Int32 param)
		{
			i_OpenGL1_2.glLightModeli(pname, param);
		}
		public static void glLightModeliv(LightModelParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glLightModeliv(pname, ref @params);
		}
		public static void glLineStipple(Int32 factor, UInt16 pattern)
		{
			i_OpenGL1_2.glLineStipple(factor, pattern);
		}
		public static void glLineWidth(Single width)
		{
			i_OpenGL1_2.glLineWidth(width);
		}
		public static void glListBase(UInt32 @base)
		{
			i_OpenGL1_2.glListBase(@base);
		}
		public static void glLoadIdentity()
		{
			i_OpenGL1_2.glLoadIdentity();
		}
		public static void glLoadMatrixd(ref Double[] m)
		{
			i_OpenGL1_2.glLoadMatrixd(ref m);
		}
		public static void glLoadMatrixf(ref Single[] m)
		{
			i_OpenGL1_2.glLoadMatrixf(ref m);
		}
		public static void glLoadName(UInt32 name)
		{
			i_OpenGL1_2.glLoadName(name);
		}
		public static void glLogicOp(LogicOp opcode)
		{
			i_OpenGL1_2.glLogicOp(opcode);
		}
		public static void glMap1d(MapTarget target, Double u1, Double u2, Int32 stride, Int32 order, ref Double[] points)
		{
			i_OpenGL1_2.glMap1d(target, u1, u2, stride, order, ref points);
		}
		public static void glMap1f(MapTarget target, Single u1, Single u2, Int32 stride, Int32 order, ref Single[] points)
		{
			i_OpenGL1_2.glMap1f(target, u1, u2, stride, order, ref points);
		}
		public static void glMap2d(MapTarget target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, ref Double[] points)
		{
			i_OpenGL1_2.glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref points);
		}
		public static void glMap2f(MapTarget target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, ref Single[] points)
		{
			i_OpenGL1_2.glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref points);
		}
		public static void glMapGrid1d(Int32 un, Double u1, Double u2)
		{
			i_OpenGL1_2.glMapGrid1d(un, u1, u2);
		}
		public static void glMapGrid1f(Int32 un, Single u1, Single u2)
		{
			i_OpenGL1_2.glMapGrid1f(un, u1, u2);
		}
		public static void glMapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2)
		{
			i_OpenGL1_2.glMapGrid2d(un, u1, u2, vn, v1, v2);
		}
		public static void glMapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2)
		{
			i_OpenGL1_2.glMapGrid2f(un, u1, u2, vn, v1, v2);
		}
		public static void glMaterialf(MaterialFace face, MaterialParameter pname, Single param)
		{
			i_OpenGL1_2.glMaterialf(face, pname, param);
		}
		public static void glMaterialfv(MaterialFace face, MaterialParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glMaterialfv(face, pname, ref @params);
		}
		public static void glMateriali(MaterialFace face, MaterialParameter pname, Int32 param)
		{
			i_OpenGL1_2.glMateriali(face, pname, param);
		}
		public static void glMaterialiv(MaterialFace face, MaterialParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glMaterialiv(face, pname, ref @params);
		}
		public static void glMatrixMode(MatrixMode mode)
		{
			i_OpenGL1_2.glMatrixMode(mode);
		}
		public static void glMultMatrixd(ref Double[] m)
		{
			i_OpenGL1_2.glMultMatrixd(ref m);
		}
		public static void glMultMatrixf(ref Single[] m)
		{
			i_OpenGL1_2.glMultMatrixf(ref m);
		}
		public static void glNewList(UInt32 list, ListMode mode)
		{
			i_OpenGL1_2.glNewList(list, mode);
		}
		public static void glNormal3b(SByte nx, SByte ny, SByte nz)
		{
			i_OpenGL1_2.glNormal3b(nx, ny, nz);
		}
		public static void glNormal3bv(ref SByte[] v)
		{
			i_OpenGL1_2.glNormal3bv(ref v);
		}
		public static void glNormal3d(Double nx, Double ny, Double nz)
		{
			i_OpenGL1_2.glNormal3d(nx, ny, nz);
		}
		public static void glNormal3dv(ref Double[] v)
		{
			i_OpenGL1_2.glNormal3dv(ref v);
		}
		public static void glNormal3f(Single nx, Single ny, Single nz)
		{
			i_OpenGL1_2.glNormal3f(nx, ny, nz);
		}
		public static void glNormal3fv(ref Single[] v)
		{
			i_OpenGL1_2.glNormal3fv(ref v);
		}
		public static void glNormal3i(Int32 nx, Int32 ny, Int32 nz)
		{
			i_OpenGL1_2.glNormal3i(nx, ny, nz);
		}
		public static void glNormal3iv(ref Int32[] v)
		{
			i_OpenGL1_2.glNormal3iv(ref v);
		}
		public static void glNormal3s(Int16 nx, Int16 ny, Int16 nz)
		{
			i_OpenGL1_2.glNormal3s(nx, ny, nz);
		}
		public static void glNormal3sv(ref Int16[] v)
		{
			i_OpenGL1_2.glNormal3sv(ref v);
		}
		public static void glNormalPointer(NormalPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL1_2.glNormalPointer(type, stride, pointer);
		}
		public static void glOrtho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar)
		{
			i_OpenGL1_2.glOrtho(left, right, bottom, top, zNear, zFar);
		}
		public static void glPassThrough(Single token)
		{
			i_OpenGL1_2.glPassThrough(token);
		}
		public static void glPixelMapfv(PixelMap map, Int32 mapsize, ref Single[] values)
		{
			i_OpenGL1_2.glPixelMapfv(map, mapsize, ref values);
		}
		public static void glPixelMapuiv(PixelMap map, Int32 mapsize, ref UInt32[] values)
		{
			i_OpenGL1_2.glPixelMapuiv(map, mapsize, ref values);
		}
		public static void glPixelMapusv(PixelMap map, Int32 mapsize, ref UInt16[] values)
		{
			i_OpenGL1_2.glPixelMapusv(map, mapsize, ref values);
		}
		public static void glPixelStoref(PixelStoreParameter pname, Single param)
		{
			i_OpenGL1_2.glPixelStoref(pname, param);
		}
		public static void glPixelStorei(PixelStoreParameter pname, Int32 param)
		{
			i_OpenGL1_2.glPixelStorei(pname, param);
		}
		public static void glPixelTransferf(PixelTransferParameter pname, Single param)
		{
			i_OpenGL1_2.glPixelTransferf(pname, param);
		}
		public static void glPixelTransferi(PixelTransferParameter pname, Int32 param)
		{
			i_OpenGL1_2.glPixelTransferi(pname, param);
		}
		public static void glPixelZoom(Single xfactor, Single yfactor)
		{
			i_OpenGL1_2.glPixelZoom(xfactor, yfactor);
		}
		public static void glPointSize(Single size)
		{
			i_OpenGL1_2.glPointSize(size);
		}
		public static void glPolygonMode(MaterialFace face, PolygonMode mode)
		{
			i_OpenGL1_2.glPolygonMode(face, mode);
		}
		public static void glPolygonOffset(Single factor, Single units)
		{
			i_OpenGL1_2.glPolygonOffset(factor, units);
		}
		public static void glPolygonStipple(ref Byte[] mask)
		{
			i_OpenGL1_2.glPolygonStipple(ref mask);
		}
		public static void glPopAttrib()
		{
			i_OpenGL1_2.glPopAttrib();
		}
		public static void glPopClientAttrib()
		{
			i_OpenGL1_2.glPopClientAttrib();
		}
		public static void glPopMatrix()
		{
			i_OpenGL1_2.glPopMatrix();
		}
		public static void glPopName()
		{
			i_OpenGL1_2.glPopName();
		}
		public static void glPrioritizeTextures(Int32 n, ref UInt32[] textures, ref Single[] priorities)
		{
			i_OpenGL1_2.glPrioritizeTextures(n, ref textures, ref priorities);
		}
		public static void glPushAttrib(UInt32 mask)
		{
			i_OpenGL1_2.glPushAttrib(mask);
		}
		public static void glPushClientAttrib(UInt32 mask)
		{
			i_OpenGL1_2.glPushClientAttrib(mask);
		}
		public static void glPushMatrix()
		{
			i_OpenGL1_2.glPushMatrix();
		}
		public static void glPushName(UInt32 name)
		{
			i_OpenGL1_2.glPushName(name);
		}
		public static void glRasterPos2d(Double x, Double y)
		{
			i_OpenGL1_2.glRasterPos2d(x, y);
		}
		public static void glRasterPos2dv(ref Double[] v)
		{
			i_OpenGL1_2.glRasterPos2dv(ref v);
		}
		public static void glRasterPos2f(Single x, Single y)
		{
			i_OpenGL1_2.glRasterPos2f(x, y);
		}
		public static void glRasterPos2fv(ref Single[] v)
		{
			i_OpenGL1_2.glRasterPos2fv(ref v);
		}
		public static void glRasterPos2i(Int32 x, Int32 y)
		{
			i_OpenGL1_2.glRasterPos2i(x, y);
		}
		public static void glRasterPos2iv(ref Int32[] v)
		{
			i_OpenGL1_2.glRasterPos2iv(ref v);
		}
		public static void glRasterPos2s(Int16 x, Int16 y)
		{
			i_OpenGL1_2.glRasterPos2s(x, y);
		}
		public static void glRasterPos2sv(ref Int16[] v)
		{
			i_OpenGL1_2.glRasterPos2sv(ref v);
		}
		public static void glRasterPos3d(Double x, Double y, Double z)
		{
			i_OpenGL1_2.glRasterPos3d(x, y, z);
		}
		public static void glRasterPos3dv(ref Double[] v)
		{
			i_OpenGL1_2.glRasterPos3dv(ref v);
		}
		public static void glRasterPos3f(Single x, Single y, Single z)
		{
			i_OpenGL1_2.glRasterPos3f(x, y, z);
		}
		public static void glRasterPos3fv(ref Single[] v)
		{
			i_OpenGL1_2.glRasterPos3fv(ref v);
		}
		public static void glRasterPos3i(Int32 x, Int32 y, Int32 z)
		{
			i_OpenGL1_2.glRasterPos3i(x, y, z);
		}
		public static void glRasterPos3iv(ref Int32[] v)
		{
			i_OpenGL1_2.glRasterPos3iv(ref v);
		}
		public static void glRasterPos3s(Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL1_2.glRasterPos3s(x, y, z);
		}
		public static void glRasterPos3sv(ref Int16[] v)
		{
			i_OpenGL1_2.glRasterPos3sv(ref v);
		}
		public static void glRasterPos4d(Double x, Double y, Double z, Double w)
		{
			i_OpenGL1_2.glRasterPos4d(x, y, z, w);
		}
		public static void glRasterPos4dv(ref Double[] v)
		{
			i_OpenGL1_2.glRasterPos4dv(ref v);
		}
		public static void glRasterPos4f(Single x, Single y, Single z, Single w)
		{
			i_OpenGL1_2.glRasterPos4f(x, y, z, w);
		}
		public static void glRasterPos4fv(ref Single[] v)
		{
			i_OpenGL1_2.glRasterPos4fv(ref v);
		}
		public static void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			i_OpenGL1_2.glRasterPos4i(x, y, z, w);
		}
		public static void glRasterPos4iv(ref Int32[] v)
		{
			i_OpenGL1_2.glRasterPos4iv(ref v);
		}
		public static void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			i_OpenGL1_2.glRasterPos4s(x, y, z, w);
		}
		public static void glRasterPos4sv(ref Int16[] v)
		{
			i_OpenGL1_2.glRasterPos4sv(ref v);
		}
		public static void glReadBuffer(ReadBufferMode src)
		{
			i_OpenGL1_2.glReadBuffer(src);
		}
		public static void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glReadPixels(x, y, width, height, format, type, pixels);
		}
		public static void glRectd(Double x1, Double y1, Double x2, Double y2)
		{
			i_OpenGL1_2.glRectd(x1, y1, x2, y2);
		}
		public static void glRectdv(ref Double[] v1, ref Double[] v2)
		{
			i_OpenGL1_2.glRectdv(ref v1, ref v2);
		}
		public static void glRectf(Single x1, Single y1, Single x2, Single y2)
		{
			i_OpenGL1_2.glRectf(x1, y1, x2, y2);
		}
		public static void glRectfv(ref Single[] v1, ref Single[] v2)
		{
			i_OpenGL1_2.glRectfv(ref v1, ref v2);
		}
		public static void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2)
		{
			i_OpenGL1_2.glRecti(x1, y1, x2, y2);
		}
		public static void glRectiv(ref Int32[] v1, ref Int32[] v2)
		{
			i_OpenGL1_2.glRectiv(ref v1, ref v2);
		}
		public static void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2)
		{
			i_OpenGL1_2.glRects(x1, y1, x2, y2);
		}
		public static void glRectsv(ref Int16[] v1, ref Int16[] v2)
		{
			i_OpenGL1_2.glRectsv(ref v1, ref v2);
		}
		public static Int32 glRenderMode(RenderingMode mode)
		{
			return i_OpenGL1_2.glRenderMode(mode);
		}
		public static void glRotated(Double angle, Double x, Double y, Double z)
		{
			i_OpenGL1_2.glRotated(angle, x, y, z);
		}
		public static void glRotatef(Single angle, Single x, Single y, Single z)
		{
			i_OpenGL1_2.glRotatef(angle, x, y, z);
		}
		public static void glScaled(Double x, Double y, Double z)
		{
			i_OpenGL1_2.glScaled(x, y, z);
		}
		public static void glScalef(Single x, Single y, Single z)
		{
			i_OpenGL1_2.glScalef(x, y, z);
		}
		public static void glScissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL1_2.glScissor(x, y, width, height);
		}
		public static void glSelectBuffer(Int32 size, ref UInt32[] buffer)
		{
			i_OpenGL1_2.glSelectBuffer(size, ref buffer);
		}
		public static void glShadeModel(ShadingModel mode)
		{
			i_OpenGL1_2.glShadeModel(mode);
		}
		public static void glStencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL1_2.glStencilFunc(func, @ref, mask);
		}
		public static void glStencilMask(UInt32 mask)
		{
			i_OpenGL1_2.glStencilMask(mask);
		}
		public static void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			i_OpenGL1_2.glStencilOp(fail, zfail, zpass);
		}
		public static void glTexCoord1d(Double s)
		{
			i_OpenGL1_2.glTexCoord1d(s);
		}
		public static void glTexCoord1dv(ref Double v)
		{
			i_OpenGL1_2.glTexCoord1dv(ref v);
		}
		public static void glTexCoord1f(Single s)
		{
			i_OpenGL1_2.glTexCoord1f(s);
		}
		public static void glTexCoord1fv(ref Single v)
		{
			i_OpenGL1_2.glTexCoord1fv(ref v);
		}
		public static void glTexCoord1i(Int32 s)
		{
			i_OpenGL1_2.glTexCoord1i(s);
		}
		public static void glTexCoord1iv(ref Int32 v)
		{
			i_OpenGL1_2.glTexCoord1iv(ref v);
		}
		public static void glTexCoord1s(Int16 s)
		{
			i_OpenGL1_2.glTexCoord1s(s);
		}
		public static void glTexCoord1sv(ref Int16 v)
		{
			i_OpenGL1_2.glTexCoord1sv(ref v);
		}
		public static void glTexCoord2d(Double s, Double t)
		{
			i_OpenGL1_2.glTexCoord2d(s, t);
		}
		public static void glTexCoord2dv(ref Double[] v)
		{
			i_OpenGL1_2.glTexCoord2dv(ref v);
		}
		public static void glTexCoord2f(Single s, Single t)
		{
			i_OpenGL1_2.glTexCoord2f(s, t);
		}
		public static void glTexCoord2fv(ref Single[] v)
		{
			i_OpenGL1_2.glTexCoord2fv(ref v);
		}
		public static void glTexCoord2i(Int32 s, Int32 t)
		{
			i_OpenGL1_2.glTexCoord2i(s, t);
		}
		public static void glTexCoord2iv(ref Int32[] v)
		{
			i_OpenGL1_2.glTexCoord2iv(ref v);
		}
		public static void glTexCoord2s(Int16 s, Int16 t)
		{
			i_OpenGL1_2.glTexCoord2s(s, t);
		}
		public static void glTexCoord2sv(ref Int16[] v)
		{
			i_OpenGL1_2.glTexCoord2sv(ref v);
		}
		public static void glTexCoord3d(Double s, Double t, Double r)
		{
			i_OpenGL1_2.glTexCoord3d(s, t, r);
		}
		public static void glTexCoord3dv(ref Double[] v)
		{
			i_OpenGL1_2.glTexCoord3dv(ref v);
		}
		public static void glTexCoord3f(Single s, Single t, Single r)
		{
			i_OpenGL1_2.glTexCoord3f(s, t, r);
		}
		public static void glTexCoord3fv(ref Single[] v)
		{
			i_OpenGL1_2.glTexCoord3fv(ref v);
		}
		public static void glTexCoord3i(Int32 s, Int32 t, Int32 r)
		{
			i_OpenGL1_2.glTexCoord3i(s, t, r);
		}
		public static void glTexCoord3iv(ref Int32[] v)
		{
			i_OpenGL1_2.glTexCoord3iv(ref v);
		}
		public static void glTexCoord3s(Int16 s, Int16 t, Int16 r)
		{
			i_OpenGL1_2.glTexCoord3s(s, t, r);
		}
		public static void glTexCoord3sv(ref Int16[] v)
		{
			i_OpenGL1_2.glTexCoord3sv(ref v);
		}
		public static void glTexCoord4d(Double s, Double t, Double r, Double q)
		{
			i_OpenGL1_2.glTexCoord4d(s, t, r, q);
		}
		public static void glTexCoord4dv(ref Double[] v)
		{
			i_OpenGL1_2.glTexCoord4dv(ref v);
		}
		public static void glTexCoord4f(Single s, Single t, Single r, Single q)
		{
			i_OpenGL1_2.glTexCoord4f(s, t, r, q);
		}
		public static void glTexCoord4fv(ref Single[] v)
		{
			i_OpenGL1_2.glTexCoord4fv(ref v);
		}
		public static void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q)
		{
			i_OpenGL1_2.glTexCoord4i(s, t, r, q);
		}
		public static void glTexCoord4iv(ref Int32[] v)
		{
			i_OpenGL1_2.glTexCoord4iv(ref v);
		}
		public static void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q)
		{
			i_OpenGL1_2.glTexCoord4s(s, t, r, q);
		}
		public static void glTexCoord4sv(ref Int16[] v)
		{
			i_OpenGL1_2.glTexCoord4sv(ref v);
		}
		public static void glTexCoordPointer(Int32 size, TexCoordPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL1_2.glTexCoordPointer(size, type, stride, pointer);
		}
		public static void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, Single param)
		{
			i_OpenGL1_2.glTexEnvf(target, pname, param);
		}
		public static void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glTexEnvfv(target, pname, ref @params);
		}
		public static void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, Int32 param)
		{
			i_OpenGL1_2.glTexEnvi(target, pname, param);
		}
		public static void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glTexEnviv(target, pname, ref @params);
		}
		public static void glTexGend(TextureCoordName coord, TextureGenParameter pname, Double param)
		{
			i_OpenGL1_2.glTexGend(coord, pname, param);
		}
		public static void glTexGendv(TextureCoordName coord, TextureGenParameter pname, ref Double[] @params)
		{
			i_OpenGL1_2.glTexGendv(coord, pname, ref @params);
		}
		public static void glTexGenf(TextureCoordName coord, TextureGenParameter pname, Single param)
		{
			i_OpenGL1_2.glTexGenf(coord, pname, param);
		}
		public static void glTexGenfv(TextureCoordName coord, TextureGenParameter pname, ref Single[] @params)
		{
			i_OpenGL1_2.glTexGenfv(coord, pname, ref @params);
		}
		public static void glTexGeni(TextureCoordName coord, TextureGenParameter pname, Int32 param)
		{
			i_OpenGL1_2.glTexGeni(coord, pname, param);
		}
		public static void glTexGeniv(TextureCoordName coord, TextureGenParameter pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glTexGeniv(coord, pname, ref @params);
		}
		public static void glTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}
		public static void glTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}
		public static void glTexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		public static void glTexParameterf(TextureTarget target, TextureParameterName pname, Single param)
		{
			i_OpenGL1_2.glTexParameterf(target, pname, param);
		}
		public static void glTexParameterfv(TextureTarget target, TextureParameterName pname, ref Single[] @params)
		{
			i_OpenGL1_2.glTexParameterfv(target, pname, ref @params);
		}
		public static void glTexParameteri(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			i_OpenGL1_2.glTexParameteri(target, pname, param);
		}
		public static void glTexParameteriv(TextureTarget target, TextureParameterName pname, ref Int32[] @params)
		{
			i_OpenGL1_2.glTexParameteriv(target, pname, ref @params);
		}
		public static void glTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}
		public static void glTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		public static void glTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL1_2.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public static void glTranslated(Double x, Double y, Double z)
		{
			i_OpenGL1_2.glTranslated(x, y, z);
		}
		public static void glTranslatef(Single x, Single y, Single z)
		{
			i_OpenGL1_2.glTranslatef(x, y, z);
		}
		public static void glVertex2d(Double x, Double y)
		{
			i_OpenGL1_2.glVertex2d(x, y);
		}
		public static void glVertex2dv(ref Double[] v)
		{
			i_OpenGL1_2.glVertex2dv(ref v);
		}
		public static void glVertex2f(Single x, Single y)
		{
			i_OpenGL1_2.glVertex2f(x, y);
		}
		public static void glVertex2fv(ref Single[] v)
		{
			i_OpenGL1_2.glVertex2fv(ref v);
		}
		public static void glVertex2i(Int32 x, Int32 y)
		{
			i_OpenGL1_2.glVertex2i(x, y);
		}
		public static void glVertex2iv(ref Int32[] v)
		{
			i_OpenGL1_2.glVertex2iv(ref v);
		}
		public static void glVertex2s(Int16 x, Int16 y)
		{
			i_OpenGL1_2.glVertex2s(x, y);
		}
		public static void glVertex2sv(ref Int16[] v)
		{
			i_OpenGL1_2.glVertex2sv(ref v);
		}
		public static void glVertex3d(Double x, Double y, Double z)
		{
			i_OpenGL1_2.glVertex3d(x, y, z);
		}
		public static void glVertex3dv(ref Double[] v)
		{
			i_OpenGL1_2.glVertex3dv(ref v);
		}
		public static void glVertex3f(Single x, Single y, Single z)
		{
			i_OpenGL1_2.glVertex3f(x, y, z);
		}
		public static void glVertex3fv(ref Single[] v)
		{
			i_OpenGL1_2.glVertex3fv(ref v);
		}
		public static void glVertex3i(Int32 x, Int32 y, Int32 z)
		{
			i_OpenGL1_2.glVertex3i(x, y, z);
		}
		public static void glVertex3iv(ref Int32[] v)
		{
			i_OpenGL1_2.glVertex3iv(ref v);
		}
		public static void glVertex3s(Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL1_2.glVertex3s(x, y, z);
		}
		public static void glVertex3sv(ref Int16[] v)
		{
			i_OpenGL1_2.glVertex3sv(ref v);
		}
		public static void glVertex4d(Double x, Double y, Double z, Double w)
		{
			i_OpenGL1_2.glVertex4d(x, y, z, w);
		}
		public static void glVertex4dv(ref Double[] v)
		{
			i_OpenGL1_2.glVertex4dv(ref v);
		}
		public static void glVertex4f(Single x, Single y, Single z, Single w)
		{
			i_OpenGL1_2.glVertex4f(x, y, z, w);
		}
		public static void glVertex4fv(ref Single[] v)
		{
			i_OpenGL1_2.glVertex4fv(ref v);
		}
		public static void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			i_OpenGL1_2.glVertex4i(x, y, z, w);
		}
		public static void glVertex4iv(ref Int32[] v)
		{
			i_OpenGL1_2.glVertex4iv(ref v);
		}
		public static void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			i_OpenGL1_2.glVertex4s(x, y, z, w);
		}
		public static void glVertex4sv(ref Int16[] v)
		{
			i_OpenGL1_2.glVertex4sv(ref v);
		}
		public static void glVertexPointer(Int32 size, VertexPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL1_2.glVertexPointer(size, type, stride, pointer);
		}
		public static void glViewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL1_2.glViewport(x, y, width, height);
		}
	}
}


#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Type
struct Type_t;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Xml.Serialization.XmlSerializerImplementation
struct XmlSerializerImplementation_t2663519657;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializer/SerializerData
struct  SerializerData_t3606741380  : public Il2CppObject
{
public:
	// System.Type System.Xml.Serialization.XmlSerializer/SerializerData::ReaderType
	Type_t * ___ReaderType_0;
	// System.Reflection.MethodInfo System.Xml.Serialization.XmlSerializer/SerializerData::ReaderMethod
	MethodInfo_t * ___ReaderMethod_1;
	// System.Type System.Xml.Serialization.XmlSerializer/SerializerData::WriterType
	Type_t * ___WriterType_2;
	// System.Reflection.MethodInfo System.Xml.Serialization.XmlSerializer/SerializerData::WriterMethod
	MethodInfo_t * ___WriterMethod_3;
	// System.Xml.Serialization.XmlSerializerImplementation System.Xml.Serialization.XmlSerializer/SerializerData::Implementation
	XmlSerializerImplementation_t2663519657 * ___Implementation_4;

public:
	inline static int32_t get_offset_of_ReaderType_0() { return static_cast<int32_t>(offsetof(SerializerData_t3606741380, ___ReaderType_0)); }
	inline Type_t * get_ReaderType_0() const { return ___ReaderType_0; }
	inline Type_t ** get_address_of_ReaderType_0() { return &___ReaderType_0; }
	inline void set_ReaderType_0(Type_t * value)
	{
		___ReaderType_0 = value;
		Il2CppCodeGenWriteBarrier(&___ReaderType_0, value);
	}

	inline static int32_t get_offset_of_ReaderMethod_1() { return static_cast<int32_t>(offsetof(SerializerData_t3606741380, ___ReaderMethod_1)); }
	inline MethodInfo_t * get_ReaderMethod_1() const { return ___ReaderMethod_1; }
	inline MethodInfo_t ** get_address_of_ReaderMethod_1() { return &___ReaderMethod_1; }
	inline void set_ReaderMethod_1(MethodInfo_t * value)
	{
		___ReaderMethod_1 = value;
		Il2CppCodeGenWriteBarrier(&___ReaderMethod_1, value);
	}

	inline static int32_t get_offset_of_WriterType_2() { return static_cast<int32_t>(offsetof(SerializerData_t3606741380, ___WriterType_2)); }
	inline Type_t * get_WriterType_2() const { return ___WriterType_2; }
	inline Type_t ** get_address_of_WriterType_2() { return &___WriterType_2; }
	inline void set_WriterType_2(Type_t * value)
	{
		___WriterType_2 = value;
		Il2CppCodeGenWriteBarrier(&___WriterType_2, value);
	}

	inline static int32_t get_offset_of_WriterMethod_3() { return static_cast<int32_t>(offsetof(SerializerData_t3606741380, ___WriterMethod_3)); }
	inline MethodInfo_t * get_WriterMethod_3() const { return ___WriterMethod_3; }
	inline MethodInfo_t ** get_address_of_WriterMethod_3() { return &___WriterMethod_3; }
	inline void set_WriterMethod_3(MethodInfo_t * value)
	{
		___WriterMethod_3 = value;
		Il2CppCodeGenWriteBarrier(&___WriterMethod_3, value);
	}

	inline static int32_t get_offset_of_Implementation_4() { return static_cast<int32_t>(offsetof(SerializerData_t3606741380, ___Implementation_4)); }
	inline XmlSerializerImplementation_t2663519657 * get_Implementation_4() const { return ___Implementation_4; }
	inline XmlSerializerImplementation_t2663519657 ** get_address_of_Implementation_4() { return &___Implementation_4; }
	inline void set_Implementation_4(XmlSerializerImplementation_t2663519657 * value)
	{
		___Implementation_4 = value;
		Il2CppCodeGenWriteBarrier(&___Implementation_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

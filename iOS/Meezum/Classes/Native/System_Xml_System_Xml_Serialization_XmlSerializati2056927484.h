#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_XmlSerializati3551839386.h"
#include "System_Xml_System_Xml_Serialization_SerializationF2842638831.h"

// System.Xml.Serialization.XmlMapping
struct XmlMapping_t1597064667;
// System.Xml.XmlQualifiedName
struct XmlQualifiedName_t1944712516;
// System.Object[]
struct ObjectU5BU5D_t3614634134;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializationReaderInterpreter
struct  XmlSerializationReaderInterpreter_t2056927484  : public XmlSerializationReader_t3551839386
{
public:
	// System.Xml.Serialization.XmlMapping System.Xml.Serialization.XmlSerializationReaderInterpreter::_typeMap
	XmlMapping_t1597064667 * ____typeMap_25;
	// System.Xml.Serialization.SerializationFormat System.Xml.Serialization.XmlSerializationReaderInterpreter::_format
	int32_t ____format_26;

public:
	inline static int32_t get_offset_of__typeMap_25() { return static_cast<int32_t>(offsetof(XmlSerializationReaderInterpreter_t2056927484, ____typeMap_25)); }
	inline XmlMapping_t1597064667 * get__typeMap_25() const { return ____typeMap_25; }
	inline XmlMapping_t1597064667 ** get_address_of__typeMap_25() { return &____typeMap_25; }
	inline void set__typeMap_25(XmlMapping_t1597064667 * value)
	{
		____typeMap_25 = value;
		Il2CppCodeGenWriteBarrier(&____typeMap_25, value);
	}

	inline static int32_t get_offset_of__format_26() { return static_cast<int32_t>(offsetof(XmlSerializationReaderInterpreter_t2056927484, ____format_26)); }
	inline int32_t get__format_26() const { return ____format_26; }
	inline int32_t* get_address_of__format_26() { return &____format_26; }
	inline void set__format_26(int32_t value)
	{
		____format_26 = value;
	}
};

struct XmlSerializationReaderInterpreter_t2056927484_StaticFields
{
public:
	// System.Xml.XmlQualifiedName System.Xml.Serialization.XmlSerializationReaderInterpreter::AnyType
	XmlQualifiedName_t1944712516 * ___AnyType_27;
	// System.Object[] System.Xml.Serialization.XmlSerializationReaderInterpreter::empty_array
	ObjectU5BU5D_t3614634134* ___empty_array_28;

public:
	inline static int32_t get_offset_of_AnyType_27() { return static_cast<int32_t>(offsetof(XmlSerializationReaderInterpreter_t2056927484_StaticFields, ___AnyType_27)); }
	inline XmlQualifiedName_t1944712516 * get_AnyType_27() const { return ___AnyType_27; }
	inline XmlQualifiedName_t1944712516 ** get_address_of_AnyType_27() { return &___AnyType_27; }
	inline void set_AnyType_27(XmlQualifiedName_t1944712516 * value)
	{
		___AnyType_27 = value;
		Il2CppCodeGenWriteBarrier(&___AnyType_27, value);
	}

	inline static int32_t get_offset_of_empty_array_28() { return static_cast<int32_t>(offsetof(XmlSerializationReaderInterpreter_t2056927484_StaticFields, ___empty_array_28)); }
	inline ObjectU5BU5D_t3614634134* get_empty_array_28() const { return ___empty_array_28; }
	inline ObjectU5BU5D_t3614634134** get_address_of_empty_array_28() { return &___empty_array_28; }
	inline void set_empty_array_28(ObjectU5BU5D_t3614634134* value)
	{
		___empty_array_28 = value;
		Il2CppCodeGenWriteBarrier(&___empty_array_28, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

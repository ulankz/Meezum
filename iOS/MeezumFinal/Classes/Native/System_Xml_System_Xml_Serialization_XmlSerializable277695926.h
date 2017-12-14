#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_XmlTypeMapping315595419.h"

// System.Xml.Schema.XmlSchema
struct XmlSchema_t880472818;
// System.Xml.Schema.XmlSchemaComplexType
struct XmlSchemaComplexType_t4086789226;
// System.Xml.XmlQualifiedName
struct XmlQualifiedName_t1944712516;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializableMapping
struct  XmlSerializableMapping_t277695926  : public XmlTypeMapping_t315595419
{
public:
	// System.Xml.Schema.XmlSchema System.Xml.Serialization.XmlSerializableMapping::_schema
	XmlSchema_t880472818 * ____schema_15;
	// System.Xml.Schema.XmlSchemaComplexType System.Xml.Serialization.XmlSerializableMapping::_schemaType
	XmlSchemaComplexType_t4086789226 * ____schemaType_16;
	// System.Xml.XmlQualifiedName System.Xml.Serialization.XmlSerializableMapping::_schemaTypeName
	XmlQualifiedName_t1944712516 * ____schemaTypeName_17;

public:
	inline static int32_t get_offset_of__schema_15() { return static_cast<int32_t>(offsetof(XmlSerializableMapping_t277695926, ____schema_15)); }
	inline XmlSchema_t880472818 * get__schema_15() const { return ____schema_15; }
	inline XmlSchema_t880472818 ** get_address_of__schema_15() { return &____schema_15; }
	inline void set__schema_15(XmlSchema_t880472818 * value)
	{
		____schema_15 = value;
		Il2CppCodeGenWriteBarrier(&____schema_15, value);
	}

	inline static int32_t get_offset_of__schemaType_16() { return static_cast<int32_t>(offsetof(XmlSerializableMapping_t277695926, ____schemaType_16)); }
	inline XmlSchemaComplexType_t4086789226 * get__schemaType_16() const { return ____schemaType_16; }
	inline XmlSchemaComplexType_t4086789226 ** get_address_of__schemaType_16() { return &____schemaType_16; }
	inline void set__schemaType_16(XmlSchemaComplexType_t4086789226 * value)
	{
		____schemaType_16 = value;
		Il2CppCodeGenWriteBarrier(&____schemaType_16, value);
	}

	inline static int32_t get_offset_of__schemaTypeName_17() { return static_cast<int32_t>(offsetof(XmlSerializableMapping_t277695926, ____schemaTypeName_17)); }
	inline XmlQualifiedName_t1944712516 * get__schemaTypeName_17() const { return ____schemaTypeName_17; }
	inline XmlQualifiedName_t1944712516 ** get_address_of__schemaTypeName_17() { return &____schemaTypeName_17; }
	inline void set__schemaTypeName_17(XmlQualifiedName_t1944712516 * value)
	{
		____schemaTypeName_17 = value;
		Il2CppCodeGenWriteBarrier(&____schemaTypeName_17, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

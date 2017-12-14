#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_XmlMapping1597064667.h"

// System.Xml.Serialization.XmlMemberMapping[]
struct XmlMemberMappingU5BU5D_t3636966742;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlMembersMapping
struct  XmlMembersMapping_t1818148568  : public XmlMapping_t1597064667
{
public:
	// System.Boolean System.Xml.Serialization.XmlMembersMapping::_hasWrapperElement
	bool ____hasWrapperElement_7;
	// System.Xml.Serialization.XmlMemberMapping[] System.Xml.Serialization.XmlMembersMapping::_mapping
	XmlMemberMappingU5BU5D_t3636966742* ____mapping_8;

public:
	inline static int32_t get_offset_of__hasWrapperElement_7() { return static_cast<int32_t>(offsetof(XmlMembersMapping_t1818148568, ____hasWrapperElement_7)); }
	inline bool get__hasWrapperElement_7() const { return ____hasWrapperElement_7; }
	inline bool* get_address_of__hasWrapperElement_7() { return &____hasWrapperElement_7; }
	inline void set__hasWrapperElement_7(bool value)
	{
		____hasWrapperElement_7 = value;
	}

	inline static int32_t get_offset_of__mapping_8() { return static_cast<int32_t>(offsetof(XmlMembersMapping_t1818148568, ____mapping_8)); }
	inline XmlMemberMappingU5BU5D_t3636966742* get__mapping_8() const { return ____mapping_8; }
	inline XmlMemberMappingU5BU5D_t3636966742** get_address_of__mapping_8() { return &____mapping_8; }
	inline void set__mapping_8(XmlMemberMappingU5BU5D_t3636966742* value)
	{
		____mapping_8 = value;
		Il2CppCodeGenWriteBarrier(&____mapping_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

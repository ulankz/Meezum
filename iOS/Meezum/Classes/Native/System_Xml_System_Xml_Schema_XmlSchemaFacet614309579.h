#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Schema_XmlSchemaAnnotated2082486936.h"
#include "System_Xml_System_Xml_Schema_XmlSchemaFacet_Facet3019654938.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Schema.XmlSchemaFacet
struct  XmlSchemaFacet_t614309579  : public XmlSchemaAnnotated_t2082486936
{
public:
	// System.String System.Xml.Schema.XmlSchemaFacet::val
	String_t* ___val_4;

public:
	inline static int32_t get_offset_of_val_4() { return static_cast<int32_t>(offsetof(XmlSchemaFacet_t614309579, ___val_4)); }
	inline String_t* get_val_4() const { return ___val_4; }
	inline String_t** get_address_of_val_4() { return &___val_4; }
	inline void set_val_4(String_t* value)
	{
		___val_4 = value;
		Il2CppCodeGenWriteBarrier(&___val_4, value);
	}
};

struct XmlSchemaFacet_t614309579_StaticFields
{
public:
	// System.Xml.Schema.XmlSchemaFacet/Facet System.Xml.Schema.XmlSchemaFacet::AllFacets
	int32_t ___AllFacets_3;

public:
	inline static int32_t get_offset_of_AllFacets_3() { return static_cast<int32_t>(offsetof(XmlSchemaFacet_t614309579_StaticFields, ___AllFacets_3)); }
	inline int32_t get_AllFacets_3() const { return ___AllFacets_3; }
	inline int32_t* get_address_of_AllFacets_3() { return &___AllFacets_3; }
	inline void set_AllFacets_3(int32_t value)
	{
		___AllFacets_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

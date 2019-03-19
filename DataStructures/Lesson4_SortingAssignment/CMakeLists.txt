cmake_minimum_required( VERSION 3.1 )

project( Lesson4_SortingAssignment )

file( GLOB_RECURSE PROJECT_HEADERS
    "${PROJECT_SOURCE_DIR}/src/*.h*"
)
file( GLOB_RECURSE PROJECT_SOURCES 
    "${PROJECT_SOURCE_DIR}/src/*.c*"
)

add_executable( ${PROJECT_NAME}
    ${PROJECT_HEADERS}
    ${PROJECT_SOURCES}
)

target_include_directories( ${PROJECT_NAME} PRIVATE
    "${PROJECT_SOURCE_DIR}/src"
)

target_link_directories( ${PROJECT_NAME} PRIVATE
)

target_link_libraries( ${PROJECT_NAME} PRIVATE
)

set_target_properties( ${PROJECT_NAME} PROPERTIES 
    CXX_STANDARD 11
    RUNTIME_OUTPUT_DIRECTORY "${PROJECT_SOURCE_DIR}/bin"
    RUNTIME_OUTPUT_DIRECTORY_DEBUG "${PROJECT_SOURCE_DIR}/bin"
    RUMTIME_OUTPUT_DIRECTORY_RELEASE "${PROJECT_SOURCE_DIR}/bin"
)

if (MSVC)
    target_compile_definitions( ${PROJECT_NAME} PRIVATE
        _CRT_SECURE_NO_WARNINGS
    )
    set_property( DIRECTORY ${PROJECT_SOURCE_DIR} PROPERTY VS_STARTUP_PROJECT "${PROJECT_NAME}" )
endif()

source_group( "Header Files" FILES
    ${PROJECT_HEADERS}
)
source_group( "Source Files" FILES
    ${PROJECT_SOURCES} 
)

//======================================================================
// VFS: Data Strucrtures And Algorithms
//======================================================================

#include "ds/arraylist.h"
#include <vector>
#include <algorithm>
#include <windows.h>
#include "randomints.h"

//======================================================================

#define NANOSECS_PER_MICROSEC (1000.0)
#define MICROSECS_PER_MILLISEC (1000.0)
#define MICROSECS_PER_SEC (1000000.0)
#define MILLISEC_PER_SEC (1000.0)
#define NANOSECS_PER_MILLISEC (NANOSECS_PER_MICROSEC * MICROSECS_PER_MILLISEC)
#define NANOSECS_PER_SEC (NANOSECS_PER_MILLISEC * MILLISEC_PER_SEC)

//======================================================================

int64_t getNanoseconds()
{
    static int64_t baseTime = 0;
    static double freq = 0.0;
    if (baseTime == 0)
    {
        QueryPerformanceFrequency( (LARGE_INTEGER*)&baseTime );
        freq = (double)baseTime / NANOSECS_PER_SEC;
        QueryPerformanceCounter( (LARGE_INTEGER*)&baseTime );
    }

    int64_t t;
    QueryPerformanceCounter( (LARGE_INTEGER*)&t );
    t -= baseTime;
    t = (uint64_t)((double)t / freq);

    return t;
}

//======================================================================

bool CompareSortedLists( const List<int32_t>& testList, const std::vector<int32_t>& refList )
{
    bool r = true;
    if (testList.Size() != refList.size())
    {
        std::cout << "Sorted list sizes don't match, test size: " << testList.Size() << " reference size: " << refList.size() << "." << std::endl;
        r = false;
    }
    for (size_t i = 0, c = refList.size(); i < c; i++)
    {
        int32_t v;
        if (!testList.At( v, (uint32_t)i ))
        {
            std::cout << "Failed to fetch index: " << i << " from test list." << std::endl;
            r = false;
            break;
        }
        if (v != refList[i])
        {
            std::cout << "testList[" << i << "]: " << v << " != refList[" << i << "]: " << refList[i] << std::endl;
            r = false;
        }
    }
    return r;
}

//======================================================================

bool VerifySort()
{
    std::cout << "Verifying sort..." << std::endl;
    uint32_t const numItererations = 100;
    uint32_t const testSize = 100;
    for (uint32_t i = 0; i < numItererations; i++)
    {
        ArrayList<int32_t> testList( testSize );
        std::vector<int32_t> refList;
        for (uint32_t i = 0; i < testSize; i++)
        {
            int32_t const v = (rand() % (testSize+1)) - (testSize/2);
            testList.Append( v );
            refList.push_back( v );
        }
        testList.Sort();
        std::sort( refList.begin(), refList.end() );
        if (!CompareSortedLists( testList, refList ))
        {
            std::cout << "Verification failed." << std::endl;
            return false;
        }
    }
    std::cout << "Verification succeeded." << std::endl;
    return true;
}

//======================================================================

void ProfileSort()
{
    std::cout << "Profiling sort..." << std::endl;
    uint32_t const numItererations = 10;
    int64_t totalTime = 0;
    for (uint32_t i = 0; i < numItererations; i++)
    {
        ArrayList<int32_t> testList( numRandomInts );
        for (int32_t i = 0; i < numRandomInts; i++)
        {
            testList.Append( randomInts[i] );
        }

        int64_t const t0 = getNanoseconds();
        testList.Sort();
        int64_t const t1 = getNanoseconds();
        totalTime += t1 - t0;
    }
    std::cout << "Sorting of " << numRandomInts << " integers " << numItererations << " times took " << ((double)totalTime / NANOSECS_PER_MILLISEC) << "ms." << std::endl;
}

//======================================================================

int main()
{
    if (VerifySort())
    {
        ProfileSort();
    }

    system( "pause" );

    return 0;
}

//======================================================================

import points_array as pts
import points_generator_alpha as alpha
import points_generator_base_b as base_b
import numpy as np
from matplotlib import pyplot as plt

### CALCULATES L2 DISCREPANCY ###

def l2_discrepancy(points):
    n, d = points.shape

    term1 = 1 / (3**d)

    _sum = 0
    for i in range(n):
        prod = 1
        for k in range(d):
            prod *= (1 - points[i, k]**2)
        _sum += prod
    term2 = (2**(1 - d) / n) * _sum

    _sum = 0
    for i in range(n):
        for j in range(n):
            prod = 1
            for k in range(d):
                prod *= (1 - max(points[i, k], points[j, k]))
            _sum += prod
    term3 = (1 / n ** 2) * _sum 

    return term1 - term2 + term3

### GRAPHS ###

def all_fibo():
    l_infi_50 = []
    l_2_50 = []
    for i in pts.list_50:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        l_2_50.append(discrepancy)

    for i in pts.l_Infi50:
        l_infi_50.append(i)
        
    plt.scatter(l_2_50, l_infi_50, label = "Set of 50 points", color = "red", marker = ".", s = 20)

    l_infi_100 = []
    l_2_100 = []
    for i in pts.list_100:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        l_2_100.append(discrepancy)

    for i in pts.l_Infi100:
        l_infi_100.append(i)

    plt.scatter(l_2_100, l_infi_100, label = "Set of 100 points", color = "blue", marker = ".", s = 20)

    l_infi_150 = []
    l_2_150 = []
    for i in pts.list_150:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        l_2_150.append(discrepancy)

    for i in pts.l_Infi150:
        l_infi_150.append(i)

    plt.scatter(l_2_150, l_infi_150, label = "Set of 150 points", color = "green", marker = ".", s = 20)

    l_infi_200 = []
    l_2_200 = []
    for i in pts.list_200:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        l_2_200.append(discrepancy)

    for i in pts.l_Infi200:
        l_infi_200.append(i)

    plt.scatter(l_2_200, l_infi_200, label = "Set of 200 points", color = "black", marker = ".", s = 20)

    plt.title("L2 discrepancy for L∞ discrepancy on sets of 50, 100, 150, and 200 points")
    plt.xlabel("L2 discrepancy")
    plt.ylabel("L∞ discrepancy")
    plt.legend()
    plt.show()

def randlatt_and_fibo50():
    l_Infi_randlatt = []
    l_2_randlatt = []
    for i in pts.list_randlatt:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        l_2_randlatt.append(discrepancy)

    for i in pts.l_Infi_randlatt:
        l_Infi_randlatt.append(i)
        
    plt.scatter(l_2_randlatt, l_Infi_randlatt, label = "Randlatt", color = "red", marker = ".", s = 20)

    l_infi_50 = []
    l_2_50 = []
    for i in pts.list_50:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        l_2_50.append(discrepancy)

    for i in pts.l_Infi50:
        l_infi_50.append(i)
        
    plt.scatter(l_2_50, l_infi_50, label = "Fibo", color = "green", marker = ".", s = 20)

    plt.title("L2 discrepancy for L∞ discrepancy on sets of Fibo (50) and Randlatt (50 points)")
    plt.xlabel("L2 discrepancy")
    plt.ylabel("L∞ discrepancy")
    plt.legend()
    plt.show()

def alpha_generated():
    l_infi_alpha = []
    l_2_alpha = []
    for i in alpha.list_of_points:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        l_2_alpha.append(discrepancy)

    for i in alpha.l_infi_alpha:
        l_infi_alpha.append(i)

    l_2_alpha_phi = l2_discrepancy(np.array(alpha.points_phi))
        
    plt.scatter(l_2_alpha, l_infi_alpha, color = "red", label = "Random α", marker = ".", s = 20)
    plt.scatter(l_2_alpha_phi, alpha.l_infi_alpha_phi, label = "α = Φ", color = "green", marker = ".", s = 20)
    plt.axis([0, 0.008, 0.025, 0.2])

    plt.title("L2 discrepancy for L∞ discrepancy with random α and α = Φ")
    plt.xlabel("L2 discrepancy")
    plt.ylabel("L∞ discrepancy")
    plt.legend()
    plt.show()

def base_b_generated():
    l_infi_base_b = []
    l_2_base_b = []
    for i in base_b.list_of_points:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        l_2_base_b.append(discrepancy)

    for i in base_b.l_infi_base_b:
        l_infi_base_b.append(i)

    plt.plot(l_2_base_b, l_infi_base_b, color = "red")
    # plt.axis([0, 0.008, 0.025, 0.2])

    plt.title("L2 discrepancy for L∞ discrepancy with base b decomposition of n")
    plt.xlabel("L2 discrepancy")
    plt.ylabel("L∞ discrepancy")
    plt.show()

def sobol():
    l_infi_sobol_3 = []
    l_infi_sobol_4 = []
    l_infi_sobol_5 = []
    l_2_sobol_3 = []
    l_2_sobol_4 = []
    l_2_sobol_5 = []
    sum_l_2_sobol_3 = 0
    sum_l_2_sobol_4 = 0
    sum_l_2_sobol_5 = 0

    for i in pts.sobol_3_sets:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        sum_l_2_sobol_3 += discrepancy
        l_2_sobol_3.append(discrepancy)

    for i in pts.l_infi_sobol_3:
        infi = np.float64(i)
        l_infi_sobol_3.append(infi)

    plt.scatter(l_2_sobol_3, l_infi_sobol_3, label = "3 dimensions", color = "blue", marker = ".", s = 20)

    for i in pts.sobol_4_sets:
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        sum_l_2_sobol_4 += discrepancy
        l_2_sobol_4.append(discrepancy)

    for i in pts.l_infi_sobol_4:
        infi = np.float64(i)
        l_infi_sobol_4.append(infi)

    plt.scatter(l_2_sobol_4, l_infi_sobol_4, label = "4 dimensions", color = "purple", marker = ".", s = 20)

    for i in pts.sobol_5_sets:  
        points = np.array(i)
        discrepancy = l2_discrepancy(points)
        sum_l_2_sobol_5 += discrepancy
        l_2_sobol_5.append(discrepancy)

    for i in pts.l_infi_sobol_5:
        infi = np.float64(i)
        l_infi_sobol_5.append(infi)

    plt.scatter(l_2_sobol_5, l_infi_sobol_5, label = "5 dimensions", color = "green", marker = ".", s = 20) 

    plt.title("L2 discrepancy for L∞ discrepancy in 2D projections of points in 5D")
    plt.xlabel("L2 discrepancy")
    plt.ylabel("L∞ discrepancy")
    plt.legend()
    plt.show()
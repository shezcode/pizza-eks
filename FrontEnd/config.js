// Set this to the backend's LoadBalancer hostname after the backend Service exists.
// Get it with:
//   kubectl get svc backend-pizza-svc -o jsonpath='{.status.loadBalancer.ingress[0].hostname}'
window.API_BASE_URL = "http://REPLACE_WITH_BACKEND_LOADBALANCER_HOSTNAME";

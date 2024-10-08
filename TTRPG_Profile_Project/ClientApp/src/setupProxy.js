const { createProxyMiddleware } = require('http-proxy-middleware');
const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:39367';

const context = [
  "/api",
  "/API",
  "/weatherforecast",
  "/item",
  "/Images",
];

const onError = (err, req, resp, target) => {
  console.error(`${err.message}`);
}

module.exports = function (app) {
  const appProxy = createProxyMiddleware(context, {
    target: target,
    secure: false,
    onError: onError,
    headers: {
      Connection: 'Keep-Alive'
    }
  });

  app.use(appProxy);
};
